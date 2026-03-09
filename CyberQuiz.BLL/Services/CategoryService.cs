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

     
        // Initializes the service used to fetch category and subcategory data.      
        public CategoryService(IQuizRepository quizRepository)
        {
            _quizRepository = quizRepository;
        }

        
        // Returns all quiz categories mapped to lightweight category DTOs.      
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

        
        // Returns subcategories for one category id mapped to subcategory DTOs.       
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

       
        // Returns categories together with their nested subcategory DTOs.       
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
