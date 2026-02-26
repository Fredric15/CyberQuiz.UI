using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.DAL.Models
{
    public class QuizModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int SubCategoryId { get; set; }
        public List<QuestionModel> Questions { get; set; } = new();
    }
}
