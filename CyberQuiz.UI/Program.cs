using CyberQuiz.UI;
using CyberQuiz.UI.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Hämta API‑URL från appsettings.json
var apiBaseUrl = builder.Configuration["ApiBaseUrl"]
    ?? throw new InvalidOperationException("ApiBaseUrl is not configured.");


// ---------------------------------------------------------
// Registrera HttpClient för varje API‑service
// ---------------------------------------------------------
builder.Services.AddHttpClient<UserApiClient>(client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});

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

builder.Services.AddHttpClient<AiTutorApiClient>(client =>
{
    var ollamaBaseUrl = builder.Configuration["Ollama:BaseUrl"] ?? "http://localhost:11434/api/";
    client.BaseAddress = new Uri(ollamaBaseUrl);
});


// ---------------------------------------------------------
// Registrera AuthStateService (global auth‑state)

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();


// ---------------------------------------------------------
// 3. Blazor Server
// ---------------------------------------------------------
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddAuthentication("Cookies").AddCookie(options =>
{
    // Vi skriver över Microsofts standard-URL med vår egen
    options.LoginPath = "/";
});
builder.Services.AddAuthorization();

var app = builder.Build();


// ---------------------------------------------------------
// 4. Middleware
// ---------------------------------------------------------
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();