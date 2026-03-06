namespace CyberQuiz.UI.Models;

public class QuestionModel
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public int SubCategoryId { get; set; }
    public IEnumerable<AnswerOptionModel> Options { get; set; } = Array.Empty<AnswerOptionModel>();

    // Backwards-compatible alias expected by UI pages
   // public IEnumerable<AnswerOptionModel> Options => AnswerOptions;
}
