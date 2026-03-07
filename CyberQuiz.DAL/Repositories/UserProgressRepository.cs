using CyberQuiz.DAL.Data;
using CyberQuiz.DAL.Models;
using CyberQuiz.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.DAL.Repositories
{
    public class UserProgressRepository : IUserProgressRepository
    {
        private readonly AppDbContext _context;

        public UserProgressRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddProgressAsync(UserProgressModel userProgress)
        {
            //Tar emot ett nytt UserProgress-objekt och sparar det i databasen.
            //Detta används när en användare gör framsteg i en subkategori för första gången.
            await _context.UserProgress.AddAsync(userProgress);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<UserProgressModel>> GetUserProgressByUserIdAsync(string userId)
        {
            //Hämtar alla UserProgress-objekt för en specifik användare baserat på deras userId.
            //Detta används för att visa användarens framsteg i olika subkategorier.
            return await _context.UserProgress
                .Where(up => up.ApplicationUserId == userId)
                .ToListAsync();
        }

        public async Task<UserProgressModel?> GetProgressAsync(string userId, int subCategoryId)
        {
            // Letar upp en specifik rad där både UserId och SubCategoryId matchar
            return await _context.UserProgress
                .FirstOrDefaultAsync(up => up.ApplicationUserId == userId && up.SubCategoryModelId == subCategoryId);
        }

        public async Task UpdateProgressAsync(UserProgressModel userProgress)
        {
            //Uppdaterar ett befintligt UserProgress-objekt i databasen.
            //Detta används när en användare gör ytterligare framsteg i en subkategori eller när deras framsteg ändras.
            _context.UserProgress.Update(userProgress);
            await _context.SaveChangesAsync();
        }
    }
}
