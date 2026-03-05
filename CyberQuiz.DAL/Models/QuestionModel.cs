using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CyberQuiz.DAL.Models
{
    public class QuestionModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<OptionModel> Options { get; set; } = new();
        public int QuizModelId { get; set; } // Foreign key till QuizModel
        [JsonIgnore]
        public QuizModel? Quiz { get; set; }
    }
}
