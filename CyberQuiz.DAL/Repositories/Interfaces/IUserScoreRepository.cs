using CyberQuiz.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.DAL.Repositories.Interfaces
{
    public interface IUserScoreRepository
    {
        // Hämtar alla poäng för en specifik användare
        Task<IEnumerable<UserScoreModel>> GetUserScoreByUserIdAsync(string userId);
        
        // Lägger till en ny poäng för en användare
        Task AddScoreAsync(UserScoreModel userScore);
    }
}
