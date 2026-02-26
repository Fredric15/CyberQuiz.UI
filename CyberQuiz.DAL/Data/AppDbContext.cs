using System;
using System.Collections.Generic;
using System.Text;
using CyberQuiz.DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace CyberQuiz.DAL.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<SubCategoryModel> SubCategories { get; set; }
        public DbSet<QuizModel> Quizzes { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<OptionModel> Options { get; set; }
        public DbSet<UserProgressModel> UserProgress { get; set; }
        public DbSet<UserScoreModel> UserScores { get; set; }
    }
}
