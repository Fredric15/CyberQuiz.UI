using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.BLL.Models.DTO
{
    public record SubCategoryProgressDto(int SubCategoryModelId, double ScorePercentage, bool IsCompleted, DateTime UnlockedAt);
}
