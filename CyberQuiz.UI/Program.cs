using CyberQuiz.UI.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Hämta API‑URL från appsettings.json
var apiBaseUrl = builder.Configuration["ApiBaseUrl"]
    ?? throw new InvalidOperationException("ApiBaseUrl is not configured.");


// ---------------------------------------------------------
// 1. Registrera HttpClient för varje API‑service
// ---------------------------------------------------------
builder.Services.AddHttpClient<CategoryApiClient>(client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});

builder.Services.AddHttpClient<QuestionApiClient>(client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});

builder.Services.AddHttpClient<AuthApiClient>(client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});

builder.Services.AddHttpClient<ProgressApiClient>(client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});


// ---------------------------------------------------------
// 2. Registrera AuthStateService (global auth‑state)
// ---------------------------------------------------------
builder.Services.AddScoped<AuthStateService>();


// ---------------------------------------------------------
// 3. Blazor Server
// ---------------------------------------------------------
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();


// ---------------------------------------------------------
// 4. Middleware
// ---------------------------------------------------------
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();