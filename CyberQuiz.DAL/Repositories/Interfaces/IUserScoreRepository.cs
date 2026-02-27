using CyberQuiz.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.DAL.Repositories.Interfaces
{
    public interface IUserScoreRepository
    {
        // Hämtar alla UserScore-objekt för en specifik användare
        Task<IEnumerable<UserScoreModel>> GetUserScoreByUserIdAsync(string userId);
        
        // Lägger till ett nytt UserScore-objekt för en användare
        Task AddScoreAsync(UserScoreModel userScore);
    }
}
