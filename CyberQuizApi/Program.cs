using CyberQuiz.DAL.Data;
using CyberQuiz.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>();

// Controllers + OpenAPI/Swagger
builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

// Development tools
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Authentication + Authorization
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
