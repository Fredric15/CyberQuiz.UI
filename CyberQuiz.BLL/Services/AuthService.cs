using CyberQuiz.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.BLL.Services
{
    //public class AuthService : IAuthService
    //{
    //    //!!funkar senare när jag har applicationUser från Fredrics kod
    //    private readonly UserManager<ApplicationUser> _userManager;

    //    public AuthService(UserManager<ApplicationUser> userManager)
    //    {
    //        _userManager = userManager;
    //    }

    //    public async Task<ApplicationUser?> ValidateUserAsync(string email, string password)
    //    {
    //        var user = await _userManager.FindByEmailAsync(email);
    //        if (user == null) return null;

    //        var isValid = await _userManager.CheckPasswordAsync(user, password);
    //        return isValid ? user : null;
    //    }

    //    public async Task<(ApplicationUser? User, IEnumerable<string> Errors)> RegisterAsync(string userName, string email, string password)
    //    {
    //        var user = new ApplicationUser { UserName = userName, Email = email };
    //        var result = await _userManager.CreateAsync(user, password);

    //        if (result.Succeeded)
    //            return (user, []);

    //        return (null, result.Errors.Select(e => e.Description));
    //    }
    //}
}
