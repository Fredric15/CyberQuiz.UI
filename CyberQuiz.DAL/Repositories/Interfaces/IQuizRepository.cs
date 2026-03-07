using CyberQuiz.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.DAL.Repositories.Interfaces
{
    public interface IQuizRepository
    {
        // Hämtar bara kategorier och subkategorier utan quiz till menyn
        Task<IEnumerable<CategoryModel>> GetAllCategoriesWithSubCAsync();

        // Hämtar en subkategori med alla dess quiz och frågor
        Task<SubCategoryModel?> GetCompleteQuizByIdAsync(int subCategoryId);

        //Hämtar en specifik subkategori om man endast vill visa progressen i den, utan quiz och frågor
        Task<SubCategoryModel?> GetSubCategoryForProgressAsync(int subCategoryId);
        // Hämtar nästa subkategori baserat på den nuvarande subkategori-id:n
        Task<int?> GetNextSubCategoryIdAsync(int currentSubCategoryId);

    }
}
