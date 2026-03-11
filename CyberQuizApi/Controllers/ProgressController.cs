using CyberQuiz.BLL.Models;
using CyberQuiz.BLL.Models.DTO;
using CyberQuiz.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace CyberQuizApi.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class ProgressController : ControllerBase
    {
        private readonly IProgressService _progressService;
        private readonly IQuestionService _questionService;

        
        // Initializes the controller used to read and submit quiz progress.    
        public ProgressController(IProgressService progressService, IQuestionService questionService)
        {
            _progressService = progressService;
            _questionService = questionService;
        }


        // Returns the authenticated user's progress for all subcategories.        
        [HttpGet("subcategories")]
        public async Task<ActionResult<IEnumerable<SubCategoryProgressDto>>> GetSubCategoryProgress()
        {
            var userId = GetUserId();
            if (userId is null)
                return Unauthorized();

            var progress = await _progressService.GetProgressForUser(userId);
            var response = progress
                .Select(p => new SubCategoryProgressDto(p.SubCategoryModelId, p.ScorePercentage, p.IsCompleted, p.UnlockedAt));

            return Ok(response);
        }

      
        // Scores a submitted subcategory quiz and stores the user's pass/fail progress.       
        [HttpPost("subcategories/submit")]
        public async Task<ActionResult<QuizSubmissionResponse>> SubmitSubCategory([FromBody] QuizSubmissionRequest request)
        {
            var userId = GetUserId();
            if (userId is null)
                return Unauthorized();

            var questions = (await _questionService.GetQuestionsBySubCategoryId(request.SubCategoryId)).ToList();
            if (questions.Count == 0)
                return BadRequest(new { message = "No questions found for this subcategory." });

            var answers = request.Answers.ToDictionary(a => a.QuestionId, a => a.AnswerOptionId);
            var correctCount = 0;

            foreach (var question in questions)
            {
                var correctAnswerId = question.Options.FirstOrDefault(a => a.IsCorrect)?.Id;
                if (correctAnswerId is null)
                    continue;

                if (answers.TryGetValue(question.Id, out var selectedAnswerId) && selectedAnswerId == correctAnswerId)
                    correctCount++;
            }

            var score = Math.Round((double)correctCount / questions.Count * 100, 2);
            var passed = score >= 80;

            await _progressService.UpsertProgress(userId, request.SubCategoryId, score, passed);

            return Ok(new QuizSubmissionResponse(score, passed));
        }

        
        // Reads the authenticated user id from common JWT claim names.       
        private string? GetUserId()
        {
            return User.FindFirstValue(JwtRegisteredClaimNames.Sub)
                ?? User.FindFirstValue("sub")
                ?? User.FindFirstValue(ClaimTypes.NameIdentifier)
                ?? User.FindFirstValue("nameid")
                ?? User.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");
        }
    }
}
