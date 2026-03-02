using CyberQuiz.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.BLL.Services.Interfaces
{
    public interface ICategoryService
    {
       
        Task<IEnumerable<CategoryModel>> GetCategories();
        Task<IEnumerable<CategoryModel>> GetCategoriesWithSubCategories();
        Task<IEnumerable<SubCategoryModel>> GetSubCategoriesByCategoryId(int categoryId);
    }

}
