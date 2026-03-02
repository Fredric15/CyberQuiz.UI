using CyberQuiz.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.BLL.Services.Interfaces
{
    public interface IQuestionService
    {
        
        Task<IEnumerable<QuestionModel>> GetQuestionsBySubCategoryId(int subCategoryId);
    }
}
