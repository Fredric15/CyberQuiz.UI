using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.BLL.Models
{
    public record QuizSubmissionRequest(int SubCategoryId, IReadOnlyList<QuizAnswer> Answers);

    public record QuizAnswer(int QuestionId, int AnswerOptionId);
}
