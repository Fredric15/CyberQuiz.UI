using CyberQuiz.UI.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

var apiBaseUrl = builder.Configuration["ApiBaseUrl"]
    ?? throw new InvalidOperationException("ApiBaseUrl is not configured.");


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

builder.Services.AddScoped<AuthStateService>();

// HttpClient för API
builder.Services.AddHttpClient("CyberQuizApi", client =>
{
    client.BaseAddress = new Uri("https://localhost:7179/"); // API URL
});

// Gör HttpClient tillgänglig för services
builder.Services.AddScoped(sp =>
{
    var factory = sp.GetRequiredService<IHttpClientFactory>();
    return factory.CreateClient("CyberQuizApi");
});

// Registrera UI‑services
builder.Services.AddScoped<AuthApiClient>();
builder.Services.AddScoped<CategoryApiClient>();
builder.Services.AddScoped<QuestionApiClient>();
builder.Services.AddScoped<ProgressApiClient>();
builder.Services.AddScoped<AuthStateService>();

// Blazor
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

// Serve static files from wwwroot (CSS, JS, images)
app.UseStaticFiles();

// Enable routing for Blazor and other endpoints
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

