using CyberQuiz.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.BLL.Models.DTO
{
    public class QuestionDTOModel
    {
        public int Id { get; internal set; }
        public string Text { get; internal set; }
        public List<OptionDTOModel> Options { get; internal set; }

    }

    public class OptionDTOModel() 
    { 
        public int Id { get; internal set; }
        public string Text { get; internal set; }
        public bool IsCorrect { get; internal set; }
    }
}
