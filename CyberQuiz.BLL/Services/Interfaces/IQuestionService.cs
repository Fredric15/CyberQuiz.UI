using CyberQuiz.BLL.Models.DTO;
using CyberQuiz.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.BLL.Services.Interfaces
{
    public interface IQuestionService
    {
        
        Task<IEnumerable<QuestionDTOModel>> GetQuestionsBySubCategoryId(int subCategoryId);
    }
}
