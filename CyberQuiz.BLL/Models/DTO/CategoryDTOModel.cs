using CyberQuiz.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.BLL.Models.DTO
{
    public class CategoryDTOModel
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; } = string.Empty;
        public string Description { get; internal set; } = string.Empty;
    }

    public class CategoryWithSubCategoriesDTOModel : CategoryDTOModel
    {
        public IEnumerable<SubCategoryDTOModel> SubCategories { get; internal set; } = [];
    }

    public class SubCategoryDTOModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Order { get; set; }
        public int UnlockThresholdPercentage { get; set; }  
        public int CategoryModelId { get; set; } 
        public List<QuizModel> Quizzes { get; set; } = new();
    }
}
