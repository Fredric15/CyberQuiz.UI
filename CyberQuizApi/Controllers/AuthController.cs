using CyberQuiz.BLL.Models;
using CyberQuiz.BLL.Services.Interfaces;
using CyberQuiz.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;



namespace CyberQuizApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IConfiguration _configuration;

        public AuthController(IAuthService authService, IConfiguration configuration)
        {
            _authService = authService;
            _configuration = configuration;
        }

      
        /// Authenticates a user and returns a signed JWT token when credentials are valid.
       [HttpPost("login")]
        public async Task<ActionResult<LoginResponse>> Login([FromBody] LoginRequest request)
        {
            var user = await _authService.ValidateUserAsync(request.Email, request.Password);
            if (user == null)
                return Unauthorized(new { message = "Invalid email or password." });

            var token = GenerateJwtToken(user);
            return Ok(new LoginResponse
            {
                Token = token,
                Email = user.Email!,
                UserName = user.UserName!
            });
        }

       
        /// Registers a new user account and returns a signed JWT token for immediate authenticated use.
        [HttpPost("register")]
        public async Task<ActionResult<LoginResponse>> Register([FromBody] RegisterRequest request)
        {
            var (user, errors) = await _authService.RegisterAsync(request.UserName, request.Email, request.Password);
            if (user == null)
                return BadRequest(new { errors });

            var token = GenerateJwtToken(user);
            return Ok(new LoginResponse
            {
                Token = token,
                Email = user.Email!,
                UserName = user.UserName!
            });
        }

       
        /// Returns a success response for client-side logout flows in JWT-based authentication.
        [Authorize]
        [HttpPost("logout")]
        public IActionResult Logout()
        {
            return Ok(new { message = "Logged out successfully." });
        }

        
        /// Returns the authenticated user's profile by reading the user id from JWT claims.
        [Authorize]
        [HttpGet("profile")]
        public async Task<ActionResult<ProfileResponse>> GetProfile()
        {
            var userId = GetUserId();
            if (userId is null)
                return Unauthorized();

            var user = await _authService.GetByIdAsync(userId);
            if (user is null)
                return NotFound(new { message = "User not found." });

            return Ok(new ProfileResponse
            {
                UserName = user.UserName ?? string.Empty,
                Email = user.Email ?? string.Empty
            });
        }

       
        //Updates the authenticated user's email address.
        [Authorize]
        [HttpPut("profile/email")]
        public async Task<ActionResult<ProfileResponse>> UpdateEmail([FromBody] UpdateEmailRequest request)
        {
            var userId = GetUserId();
            if (userId is null)
                return Unauthorized();

            var user = await _authService.GetByIdAsync(userId);
            if (user is null)
                return NotFound(new { message = "User not found." });

            var errors = (await _authService.UpdateEmailAsync(user, request.Email)).ToList();
            if (errors.Count > 0)
                return BadRequest(new { errors });

            return Ok(new ProfileResponse
            {
                UserName = user.UserName ?? string.Empty,
                Email = user.Email ?? string.Empty
            });
        }


        // Changes the authenticated user's password.
        [Authorize]
        [HttpPut("profile/password")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequest request)
        {
            var userId = GetUserId();
            if (userId is null)
                return Unauthorized();

            var user = await _authService.GetByIdAsync(userId);
            if (user is null)
                return NotFound(new { message = "User not found." });

            var errors = (await _authService.ChangePasswordAsync(user, request.CurrentPassword, request.NewPassword)).ToList();
            if (errors.Count > 0)
                return BadRequest(new { errors });

            return Ok(new { message = "Password updated successfully." });
        }

        /// <summary>
        /// Builds and signs a JWT token that stores the user's id and identity claims.
        /// </summary>
        private string GenerateJwtToken(ApplicationUser user)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            // Uses the configured secret key to sign the JWT so the API can verify token integrity.
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["SecretKey"]!));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Stores user identity data inside JWT claims for later authorization and user lookup.
            var claims = new[]
            {
            new Claim(JwtRegisteredClaimNames.Sub, user.Id),
            new Claim(JwtRegisteredClaimNames.Email, user.Email!),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.Name, user.UserName!)
        };

            // Creates the JWT with issuer, audience and expiration from configuration.
            var token = new JwtSecurityToken(
                issuer: jwtSettings["Issuer"],
                audience: jwtSettings["Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(double.Parse(jwtSettings["ExpirationMinutes"]!)),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

       
        // Reads the current user id from common JWT claim names.
        private string? GetUserId()
        {
            return User.FindFirstValue(JwtRegisteredClaimNames.Sub)
                ?? User.FindFirstValue("sub")
                ?? User.FindFirstValue(ClaimTypes.NameIdentifier)
                ?? User.FindFirstValue("nameid")
                ?? User.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");
        }
    }
}
