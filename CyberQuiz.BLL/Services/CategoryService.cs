using CyberQuiz.BLL.Models.DTO;
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

        public async Task<IEnumerable<CategoryDTOModel>> GetCategories()
        {
            var categories = await _quizRepository.GetAllCategoriesWithSubCAsync();

            // Map to DTO 
            return categories.Select(c => new CategoryDTOModel
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description
            }).ToList();
        }

        public async Task<IEnumerable<SubCategoryDTOModel>> GetSubCategoriesByCategoryId(int categoryId)
        {
            var categories = await _quizRepository.GetAllCategoriesWithSubCAsync();

            var subCategory = categories.FirstOrDefault(c => c.Id == categoryId)?.SubCategories ?? [];

            // Map to DTO
            return subCategory.Select(sc => new SubCategoryDTOModel
            {
                Id = sc.Id,
                Name = sc.Name,
                Description = sc.Description,
                Order = sc.Order,
                UnlockThresholdPercentage = sc.UnlockThresholdPercentage,
                CategoryModelId = sc.CategoryModelId
            }).ToList();
        }

        public async Task<IEnumerable<CategoryWithSubCategoriesDTOModel>> GetCategoriesWithSubCategories()
        {
            var subCategories = await _quizRepository.GetAllCategoriesWithSubCAsync();

            // Map to DTO
            return subCategories.Select(c => new CategoryWithSubCategoriesDTOModel
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
                SubCategories = c.SubCategories.Select(sc => new SubCategoryDTOModel
                {
                    Id = sc.Id,
                    Name = sc.Name,
                    Description = sc.Description,
                    Order = sc.Order,
                    UnlockThresholdPercentage = sc.UnlockThresholdPercentage,
                    CategoryModelId = sc.CategoryModelId
                }).ToList()
            }).ToList();
        }
    }

}
