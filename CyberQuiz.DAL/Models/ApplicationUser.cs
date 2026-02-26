using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.DAL.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Så att vi kan spåra användarens framsteg och poäng
        public List<UserProgressModel> UserProgress { get; set; } = new();
        public List<UserScoreModel> UserScores { get; set; } = new();
    }
}
