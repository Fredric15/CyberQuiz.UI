namespace CyberQuiz.UI.Models;

public class UserStatsModel
{
    public int CorrectAnswers { get; set; }
    public int TotalQuestions { get; set; }

    // Basic logik för denna lilla uträkningen
    public int Percentage
    {
        get
        {
            if (TotalQuestions == 0)
                return 0;

            return (int)((double)CorrectAnswers / TotalQuestions * 100);
        }
    }

}
