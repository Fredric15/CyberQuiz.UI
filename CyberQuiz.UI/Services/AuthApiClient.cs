using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

namespace CyberQuiz.UI.Services;

public record LoginResult(string Token, string Email, string UserName);

public class AuthApiClient
{
    private readonly HttpClient _httpClient;

    public AuthApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<(bool Success, LoginResult? Result, string? Error)> LoginAsync(string email, string password)
    {
        var response = await _httpClient.PostAsJsonAsync("api/auth/login", new { Email = email, Password = password });
        if (response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadFromJsonAsync<LoginResult>();
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

        var errors = await ParseErrorsAsync(response);
        return (false, null, errors);
    }

    public async Task LogoutAsync(string token)
    {
        var request = new HttpRequestMessage(HttpMethod.Post, "api/auth/logout");
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        await _httpClient.SendAsync(request);
    }

    private static async Task<IEnumerable<string>> ParseErrorsAsync(HttpResponseMessage response)
    {
        try
        {
            var json = await response.Content.ReadFromJsonAsync<JsonElement>();
            if (json.TryGetProperty("errors", out var errorsElement))
                return errorsElement.EnumerateArray().Select(e => e.GetString() ?? string.Empty);
        }
        catch { }

        return ["An unexpected error occurred. Please try again."];
    }
}
