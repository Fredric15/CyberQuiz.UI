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

        // Lägger till ett nytt UserScore-objekt kopplat till en användare och ett quiz
        Task AddScoreAsync(UserScoreModel userScore);
    }
}
