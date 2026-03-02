namespace CyberQuiz.UI.Models;

public class QuizDetailsDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public List<QuestionDto> Questions { get; set; } = new();
}

public class QuestionDto
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public List<AnswerOptionModel> Options { get; set; } = new();
}

public class QuizResultDto
{
    public bool Passed { get; set; }
    public int CorrectAnswers { get; set; }
    public int TotalQuestions { get; set; }
    public string Message { get; set; } = string.Empty;
}

public record UserAnswerDto(int QuestionId, int AnswerOptionId);
