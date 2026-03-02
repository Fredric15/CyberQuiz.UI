using CyberQuiz.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace CyberQuiz.DAL.Data.SeedData
{
    public static class SeedUser
    {
        public static async Task SeedDefaultUserAsync(UserManager<ApplicationUser> userManager)
        {
            var userName = "user";
            var email = "user@example.com";
            var password = "Password1234!";

            //Kolla om användaren redan finns i databasen
            if (await userManager.FindByEmailAsync(email) != null)
                return;

            //Skapa användarobjektet
            var user = new ApplicationUser
            {
                UserName = userName,
                Email = email,
                EmailConfirmed = true
            };

            //Låt UserManager hantera hashning och sparning
            var result = await userManager.CreateAsync(user, password);

        }
    }
}

