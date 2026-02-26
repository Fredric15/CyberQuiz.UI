using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.DAL.Models
{
    public class OptionModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public int QuestionModelId { get; set; } // Foreign key till QuestionModel
        public QuestionModel? Question { get; set; }
    }
}
