using CyberQuiz.BLL.Services.Interfaces;
using CyberQuiz.DAL.Models;
using CyberQuiz.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CyberQuiz.BLL.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuizRepository _quizRepository;

        public QuestionService(IQuizRepository quizRepository)
        {
            _quizRepository = quizRepository;
        }

        public async Task<IEnumerable<QuestionModel>> GetQuestionsBySubCategoryId(int subCategoryId)
        {
            var subCategory = await _quizRepository.GetCompleteQuizByIdAsync(subCategoryId);
            if (subCategory is null)
            {
                return [];
            }

            return subCategory.Quizzes.SelectMany(q => q.Questions).ToList();
        }
    }
}
