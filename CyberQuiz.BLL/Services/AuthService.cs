using CyberQuiz.BLL.Services.Interfaces;
using CyberQuiz.DAL.Models;
using Microsoft.AspNetCore.Identity;

namespace CyberQuiz.BLL.Services
{
    public class AuthService : IAuthService
    {
        
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }


        
        // Verifies that the provided email and password belong to a valid user.
        public async Task<ApplicationUser?> ValidateUserAsync(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null) return null;

            var isValid = await _userManager.CheckPasswordAsync(user, password);
            return isValid ? user : null;
        }

        // Creates a new identity user and returns validation errors if creation fails.
        public async Task<(ApplicationUser? User, IEnumerable<string> Errors)> RegisterAsync(string userName, string email, string password)
        {
            var user = new ApplicationUser { UserName = userName, Email = email };
            var result = await _userManager.CreateAsync(user, password);

            if (result.Succeeded)
                return (user, []);

            return (null, result.Errors.Select(e => e.Description));
        }

        // Retrieves a user by identity id.
        public async Task<ApplicationUser?> GetByIdAsync(string userId)
        {
            return await _userManager.FindByIdAsync(userId);
        }

        
        /// Updates the email address for an existing user.
        public async Task<IEnumerable<string>> UpdateEmailAsync(ApplicationUser user, string newEmail)
        {
            user.Email = newEmail;

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
                return [];

            return result.Errors.Select(e => e.Description);
        }

        
        //Changes a user's password after validating the current password.
        public async Task<IEnumerable<string>> ChangePasswordAsync(ApplicationUser user, string currentPassword, string newPassword)
        {
            var result = await _userManager.ChangePasswordAsync(user, currentPassword, newPassword);
            if (result.Succeeded)
                return [];

            return result.Errors.Select(e => e.Description);
        }
    }
}
