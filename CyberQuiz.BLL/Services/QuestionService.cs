using CyberQuiz.BLL.Models.DTO;
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

        public async Task<IEnumerable<QuestionDTOModel>> GetQuestionsBySubCategoryId(int subCategoryId)
        {
            var subCategory = await _quizRepository.GetCompleteQuizByIdAsync(subCategoryId);
            if (subCategory is null)
            {
                return [];
            }

            var questions = subCategory.Quizzes.SelectMany(q => q.Questions).ToList();
            // Map the questions to QuestionDTOModel
            var questionDTOs = questions.Select(q => new QuestionDTOModel
            {
                Id = q.Id,
                Text = q.Text,
                Options = q.Options.Select(o => new OptionDTOModel
                {
                    Id = o.Id,
                    Text = o.Text,
                    IsCorrect = o.IsCorrect
                }).ToList()
               
            }).ToList();
            return questionDTOs;
        }
    }
}
