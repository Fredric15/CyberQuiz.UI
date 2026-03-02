namespace CyberQuiz.UI.Models;

public class SubCategoryProgressModel
{
    public int SubCategoryId { get; set; }
    public double ScorePercentage { get; set; }
    public bool IsPassed { get; set; }
    public DateTime CompletedAt { get; set; }
}
