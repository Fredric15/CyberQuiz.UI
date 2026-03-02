using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.DAL.Models
{
    public class UserProgressModel
    {
        public int Id { get; set; }

        // Koppling till användaren
        public string ApplicationUserId { get; set; } // Koppla till Identity User
        public ApplicationUser? ApplicationUser { get; set; }

        // Koppling till en specifik underkategori
        public int SubCategoryModelId { get; set; } // Koppla till SubCategoryModel
        public SubCategoryModel? SubCategory { get; set; }

        // Är den avklarad?
        public bool IsCompleted { get; set; }

        // När underkategorin låstes upp (om den inte var upplåst från början)
        public DateTime UnlockedAt { get; set; } = DateTime.UtcNow;
    }
}
