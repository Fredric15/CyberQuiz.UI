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
            //Skapar ett nytt UserScore-objekt och lägger till den i databasen
            await _context.UserScores.AddAsync(userScore);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<UserScoreModel>> GetUserScoreByUserIdAsync(string userId)
        {
            // Hämtar alla UserScore-objekt som matchar det angivna userId och returnerar dem som en lista
            return await _context.UserScores
                .Where(us => us.ApplicationUserId == userId)
                .ToListAsync();
        }
    }
}
