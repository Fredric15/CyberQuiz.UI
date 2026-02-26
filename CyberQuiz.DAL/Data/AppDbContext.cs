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
    }
}
