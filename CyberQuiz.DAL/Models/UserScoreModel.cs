using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.DAL.Models
{
    public class UserScoreModel
    {
        public int Id { get; set; }
        
        //Koppling till användaren
        public string ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        //Koppling till ett specifikt quiz
        public int QuizId { get; set; }
        public QuizModel? Quiz { get; set; }

        //Resultat av quizet
        public int Score { get; set; } //Antal rätta svar
        public int TotalQuestions { get; set; } //Totalt antal frågor i quizet
        public DateTime CompletedAt { get; set; }
    }
}
