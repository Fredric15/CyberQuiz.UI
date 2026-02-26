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
        public int Order { get; set; }
        public int UnlockThresholdPercentage { get; set; }
        public int CategoryId { get; set; }
        public List<QuizModel> Quizzes { get; set; } = new();

    }
}
