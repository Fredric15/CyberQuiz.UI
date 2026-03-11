using System.Net.Http.Headers;
using System.Text.Json;
using CyberQuiz.UI.Models;
using Microsoft.AspNetCore.Components.Authorization;

namespace CyberQuiz.UI.Services;

public record LoginResult(string Token, string Email, string UserName);

public class AuthApiClient
{
    private readonly HttpClient _httpClient;
    private readonly AuthenticationStateProvider _authStateProvider;

    public AuthApiClient(HttpClient httpClient, AuthenticationStateProvider authStateProvider)
    {
        _httpClient = httpClient;
        _authStateProvider = authStateProvider;
    }

    public async Task<(bool Success, LoginResult? Result, string? Error)> LoginAsync(string email, string password)
    {
        var response = await _httpClient.PostAsJsonAsync("api/auth/login", new { Email = email, Password = password });
        if (response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadFromJsonAsync<LoginResult>();

            //Här sparar vi in token i ProtectedSessionStorage så att den kan användas i andra delar av appen
            var customProvider = (CustomAuthStateProvider)_authStateProvider;
            await customProvider.MarkUserAsAuthenticated(result.Token);

            return (true, result, null);
        }

        return (false, null, "Invalid email or password.");
    }

    public async Task<(bool Success, LoginResult? Result, IEnumerable<string> Errors)> RegisterAsync(string userName, string email, string password)
    {
        var response = await _httpClient.PostAsJsonAsync("api/auth/register", new { UserName = userName, Email = email, Password = password });
        if (response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadFromJsonAsync<LoginResult>();
            return (true, result, []);
        }

        //var errors = await ParseErrorsAsync(response);
        return (false, null, []);
    }

    public async Task LogOutAsync()
    {
        // Radera token-strängen och bli unauthorizead/utloggad
        var customProvider = (CustomAuthStateProvider)_authStateProvider;
        await customProvider.MarkUserAsLoggedOut();
    }
}

