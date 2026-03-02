using CyberQuiz.BLL.Services.Interfaces;
using CyberQuiz.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace CyberQuizApi.Controllers
{
    [ApiController]
    [Route("api/subcategories")]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionService _questionService;

        public QuestionsController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpGet("{subCategoryId}/questions")]
        public async Task<ActionResult<IEnumerable<QuestionModel>>> GetQuestions(int subCategoryId)
        {
            var questions = await _questionService.GetQuestionsBySubCategoryId(subCategoryId);
            return Ok(questions);
        }
    }
}
