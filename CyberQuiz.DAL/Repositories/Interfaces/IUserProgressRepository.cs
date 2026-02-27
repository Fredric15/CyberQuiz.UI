using CyberQuiz.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.DAL.Repositories.Interfaces
{
    public interface IUserProgressRepository
    {
        // Hämtar alla UserProgress-objekt för en specifik användare
        Task<IEnumerable<UserProgressModel>> GetUserProgressByUserIdAsync(string userId);
        
        // Lägger till ett nytt UserProgress-objekt för en användare
        Task AddProgressAsync(UserProgressModel userProgress);
        
        // Uppdaterar ett befintligt UserProgress-objekt för en användare
        Task UpdateProgressAsync(UserProgressModel userProgress);
    }
}
