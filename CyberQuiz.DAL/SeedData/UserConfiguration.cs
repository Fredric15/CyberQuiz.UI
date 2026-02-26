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

            
            var testUser = new ApplicationUser
            {
                Id = "C4A682B7-878D-49C9-9DE5-A0AF381897D0",
                UserName = "user",
                NormalizedUserName = "USER",
                Email = "user@example.com",
                NormalizedEmail = "USER@EXAMPLE.COM",
                EmailConfirmed = true,
                SecurityStamp = "STATIC_STAMP_FOR_SEED_USER"
            };

            // Färdighashat lösenord "Password1234!" (du kan ändra det till vad du vill)
            testUser.PasswordHash = "AQAAAAIAAYagAAAAEOvE+26L3R0fA3tG8s9D6nS+hX/GjD3U/g1rM3I/6aKzFjF9jR2L+Q==";
            builder.HasData(testUser);
        }
    }
}
