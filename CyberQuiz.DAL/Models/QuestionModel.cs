using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.DAL.Models
{
    public class QuestionModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<OptionModel> Options { get; set; } = new();
        public int QuizId { get; set; }
        public QuizModel? Quiz { get; set; }
    }
}
