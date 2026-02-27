using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.DAL.Models
{
    public class QuizModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public int SubCategoryModelId { get; set; }
        public List<QuestionModel> Questions { get; set; } = new();
    }
}
