using CyberQuiz.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.BLL.Services.Interfaces
{
    public interface IAuthService
    {
        
        Task<ApplicationUser?> ValidateUserAsync(string email, string password);
        Task<(ApplicationUser? User, IEnumerable<string> Errors)> RegisterAsync(string userName, string email, string password);
    }

}
