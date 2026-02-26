using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.DAL.Models
{
    public class SubCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; }
        public int Order { get; set; } // För att bestämma ordningen av underkategorier inom en kategori
        public int UnlockThresholdPercentage { get; set; } // Procentandel av rätta svar i föregående underkategori som krävs för att låsa upp denna underkategori
        public int CategoryModelId { get; set; } // Koppling till CategoryModel
        public List<QuizModel> Quizzes { get; set; } = new();

    }
}
