using CyberQuiz.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace CyberQuiz.DAL.Data.SeedData
{
    public class QuizConfiguration : IEntityTypeConfiguration<QuizModel>
    {
        public void Configure(EntityTypeBuilder<QuizModel> builder)
        {
           builder.HasData(
                new QuizModel
                {
                    Id = 1,
                    Text = "Firewall Basics",
                    Description = "Test your knowledge on the fundamentals of firewalls.",
                    SubCategoryModelId = 1
                },
                new QuizModel
                {
                    Id = 2,
                    Text = "VPN Protocols",
                    Description = "Assess your understanding of various VPN protocols and their uses.",
                    SubCategoryModelId = 2
                },
                new QuizModel
                {
                    Id = 3,
                    Text = "Intrusion Detection Systems",
                    Description = "Evaluate your grasp of IDS concepts and technologies.",
                    SubCategoryModelId = 3
                },
                new QuizModel
                {
                    Id = 4,
                    Text = "Symmetric Encryption Algorithms",
                    Description = "Challenge yourself with questions about popular symmetric encryption algorithms.",
                    SubCategoryModelId = 4
                },
                new QuizModel
                {
                    Id = 5,
                    Text = "Asymmetric Encryption Concepts",
                    Description = "Test your knowledge of asymmetric encryption principles and applications.",
                    SubCategoryModelId = 5
                },
                new QuizModel
                {
                    Id = 6,
                    Text = "Hashing Techniques",
                    Description = "Test your understanding of various hashing techniques and their applications.",
                    SubCategoryModelId = 6
                },
                new QuizModel
                {
                    Id = 7,
                    Text = "SQL Injection Vulnerabilities",
                    Description = "Assess your knowledge of SQL injection vulnerabilities and how to prevent them.",
                    SubCategoryModelId = 7
                },
                new QuizModel
                {
                    Id = 8,
                    Text = "Cross-Site Scripting (XSS) Attacks",
                    Description = "Evaluate your understanding of cross-site scripting (XSS) attacks and how to mitigate them.",
                    SubCategoryModelId = 8
                },
                new QuizModel
                {
                    Id = 9,
                    Text = "Cross-Site Request Forgery (CSRF) Attacks",
                    Description = "Test your understanding of cross-site request forgery (CSRF) attacks and how to prevent them.",
                    SubCategoryModelId = 9
                }
            );
        }
    }
}
