using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.BLL.Models
{
    public record QuizSubmissionResponse(double ScorePercentage, bool IsPassed);
}
