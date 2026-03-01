using CyberQuiz.BLL.Services.Interfaces;
using CyberQuiz.DAL.Models;
using CyberQuiz.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CyberQuiz.BLL.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IQuizRepository _quizRepository;

        public CategoryService(IQuizRepository quizRepository)
        {
            _quizRepository = quizRepository;
        }

        public async Task<IEnumerable<CategoryModel>> GetCategories()
        {
            var categories = await _quizRepository.GetAllCategoriesWithSubCAsync();
            return categories.Select(c => new CategoryModel
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description
            }).ToList();
        }

        public async Task<IEnumerable<SubCategoryModel>> GetSubCategoriesByCategoryId(int categoryId)
        {
            var categories = await _quizRepository.GetAllCategoriesWithSubCAsync();
            return categories.FirstOrDefault(c => c.Id == categoryId)?.SubCategories ?? [];
        }

        public async Task<IEnumerable<CategoryModel>> GetCategoriesWithSubCategories()
        {
            return await _quizRepository.GetAllCategoriesWithSubCAsync();
        }
    }

}
