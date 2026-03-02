namespace CyberQuiz.UI.Models;

public class QuizSubmissionRequestModel
{
    public int QuizId { get; set; }
    public int SubCategoryId { get; set; }
    public string? UserName { get; set; }
    public IReadOnlyList<QuizAnswerModel> Answers { get; set; } = Array.Empty<QuizAnswerModel>();
}

public class QuizAnswerModel
{
    public int QuestionId { get; set; }
    public int AnswerOptionId { get; set; }
}
