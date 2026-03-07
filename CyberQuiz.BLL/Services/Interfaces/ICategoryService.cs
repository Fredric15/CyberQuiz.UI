using CyberQuiz.BLL.Models.DTO;
using CyberQuiz.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.BLL.Services.Interfaces
{
    public interface ICategoryService
    {
       
        Task<IEnumerable<CategoryDTOModel>> GetCategories();
        Task<IEnumerable<CategoryWithSubCategoriesDTOModel>> GetCategoriesWithSubCategories();
        Task<IEnumerable<SubCategoryDTOModel>> GetSubCategoriesByCategoryId(int categoryId);
    }

}
