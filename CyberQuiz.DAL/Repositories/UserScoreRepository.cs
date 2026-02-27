using CyberQuiz.DAL.Data;
using CyberQuiz.DAL.Models;
using CyberQuiz.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.DAL.Repositories
{
    public class UserScoreRepository : IUserScoreRepository
    {
        private readonly AppDbContext _context;
        public UserScoreRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddScoreAsync(UserScoreModel userScore)
        {
            // Lägger till ett nytt UserScore-objekt kopplat till en användare och ett quiz och sparar det i databasen
            await _context.UserScores.AddAsync(userScore);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<UserScoreModel>> GetUserScoreByUserIdAsync(string userId)
        {
            // Hämtar alla UserScore-objekt som matchar det angivna userId och returnerar dem som en lista
            // Detta används för att visa användarens poäng i olika quiz
            return await _context.UserScores
                .Where(us => us.ApplicationUserId == userId)
                .ToListAsync();
        }
    }
}
