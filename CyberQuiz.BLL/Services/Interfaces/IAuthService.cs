using CyberQuiz.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.BLL.Services.Interfaces
{
    public interface IAuthService
    {

        //Validates a user's credentials and returns the user when authentication succeeds.
        Task<ApplicationUser?> ValidateUserAsync(string email, string password);


        // Creates a new user account and returns validation errors when registration fails.
        Task<(ApplicationUser? User, IEnumerable<string> Errors)> RegisterAsync(string userName, string email, string password);


        // Finds a user by identifier.
        Task<ApplicationUser?> GetByIdAsync(string userId);

        // Updates the user's email and returns identity validation errors when the update fails.
        Task<IEnumerable<string>> UpdateEmailAsync(ApplicationUser user, string newEmail);


        // Changes the user's password and returns identity validation errors when the change fails.
        Task<IEnumerable<string>> ChangePasswordAsync(ApplicationUser user, string currentPassword, string newPassword);
    }


}
