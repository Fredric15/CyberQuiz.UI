using System.Text.Json.Serialization;

namespace CyberQuiz.UI.Models;

public class SubCategoryProgressModel
{
    [JsonPropertyName("subCategoryModelId")]
    public int SubCategoryId { get; set; }

    public double ScorePercentage { get; set; }

    [JsonPropertyName("isCompleted")]
    public bool IsPassed { get; set; }

    [JsonPropertyName("unlockedAt")]
    public DateTime CompletedAt { get; set; }
}
