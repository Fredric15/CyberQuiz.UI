using CyberQuiz.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.DAL.SeedData
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            //Skapa en instans av PasswordHasher för att hasha lösenordet
            var hasher = new PasswordHasher<ApplicationUser>();
            
            var testUser = new ApplicationUser
            {
                Id = "C4A682B7-878D-49C9-9DE5-A0AF381897D0",
                UserName = "user",
                NormalizedUserName = "USER",
                Email = "user@example.com",
                NormalizedEmail = "USER@EXAMPLE.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            // Hasha lösenordet och tilldela det till user och spara det i databasen
            testUser.PasswordHash = hasher.HashPassword(testUser, "Password1234!");
            builder.HasData(testUser);
        }
    }
}
