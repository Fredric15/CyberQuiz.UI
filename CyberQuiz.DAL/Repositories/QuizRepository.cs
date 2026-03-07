using CyberQuiz.DAL.Data;
using CyberQuiz.DAL.Models;
using CyberQuiz.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.DAL.Repositories
{
    public class QuizRepository : IQuizRepository
    {
        private readonly AppDbContext _context;
        public QuizRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<CategoryModel>> GetAllCategoriesWithSubCAsync()
        {
            //Hämtar alla kategorier och inkluderar deras underkategorier till menyerna
            //Men inga frågor eller svarsalternativ för att spara prestanda

            return await _context.Categories
                .Include(c => c.SubCategories)
                .ToListAsync();
        }

        public async Task<SubCategoryModel?> GetCompleteQuizByIdAsync(int subCategoryId)
        {
            //Hämtar en specifik underkategori och inkluderar alla dess quiz, frågor och svarsalternativ

            return await _context.SubCategories
                .Include(sc => sc.Quizzes)
                    .ThenInclude(q => q.Questions)
                    .ThenInclude(q => q.Options)
                .FirstOrDefaultAsync(sc => sc.Id == subCategoryId);
        }

        public async Task<SubCategoryModel?> GetSubCategoryForProgressAsync(int subCategoryId)
        {
            //Hämtar en specifik underkategori utan quiz och frågor, endast för att visa progressen i den
            return await _context.SubCategories
                .FirstOrDefaultAsync(sc => sc.Id == subCategoryId);
        }

        public async Task<int?> GetNextSubCategoryIdAsync(int currentSubCategoryId)
        {
            // 1. Först måste vi hitta den nuvarande underkategorin för att veta vilken Huvudkategori den tillhör
            var currentSubCategory = await _context.SubCategories
                .FirstOrDefaultAsync(sc => sc.Id == currentSubCategoryId);

            if (currentSubCategory == null)
            {
                return null; // Hittades inte
            }

            // 2. Leta upp nästa underkategori i samma huvudkategori (den som har ett högre ID)
            var nextSubCategory = await _context.SubCategories
                .Where(sc => sc.CategoryModelId == currentSubCategory.CategoryModelId && sc.Order > currentSubCategory.Order)
                .OrderBy(sc => sc.Order) // Sortera så vi garanterat får den som ligger precis efter
                .FirstOrDefaultAsync();

            return nextSubCategory?.Id;
        }
    }
}
