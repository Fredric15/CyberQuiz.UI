using CyberQuiz.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.DAL.Data.SeedData
{
    public class CategoryConfiguration : IEntityTypeConfiguration<CategoryModel>
    {
        public void Configure(EntityTypeBuilder<CategoryModel> builder)
        {
            builder.HasData(
                new CategoryModel
                {
                    Id = 1,
                    Name = "Network Security",
                    Description = "Fundamentals of securing network infrastructure and communications."
                },
                new CategoryModel
                {
                    Id = 2,
                    Name = "Cryptography",
                    Description = "Principles and algorithms used to protect information through encryption."
                },
                new CategoryModel
                {
                    Id = 3,
                    Name = "Web Security",
                    Description = "Vulnerabilities and defenses related to web applications and browsers."
                }
            );
        }
    }
}
