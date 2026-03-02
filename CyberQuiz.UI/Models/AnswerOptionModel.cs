namespace CyberQuiz.UI.Models;

public class AnswerOptionModel
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public bool IsCorrect { get; set; }
}
