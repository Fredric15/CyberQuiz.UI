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
        // Radera token-strängen i ProtectedSessionStorage
        var customProvider = (CustomAuthStateProvider)_authStateProvider;
        await customProvider.MarkUserAsLoggedOut();
    }
}

//    public async Task<(bool Success, UserProfileModel? Profile, IEnumerable<string> Errors)> GetProfileAsync()
//    {
//        if (!_authStateService.IsAuthenticated)
//            return (false, null, ["You are not logged in."]);

//        var request = CreateAuthorizedRequest(HttpMethod.Get, "api/auth/profile");
//        var response = await _httpClient.SendAsync(request);

//        if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
//        {
//            _authStateService.ClearUser();
//            return (false, null, ["Your session has expired. Please log in again."]);
//        }

//        if (!response.IsSuccessStatusCode)
//            return (false, null, await ParseErrorsAsync(response));

//        var profile = await response.Content.ReadFromJsonAsync<UserProfileModel>();
//        return profile is null
//            ? (false, null, ["Failed to load profile."])
//            : (true, profile, []);
//    }

//    public async Task<(bool Success, UserProfileModel? Profile, IEnumerable<string> Errors)> UpdateEmailAsync(string email)
//    {
//        if (!_authStateService.IsAuthenticated)
//            return (false, null, ["You are not logged in."]);

//        var request = CreateAuthorizedRequest(HttpMethod.Put, "api/auth/profile/email");
//        request.Content = JsonContent.Create(new { Email = email });
//        var response = await _httpClient.SendAsync(request);

//        if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
//        {
//            _authStateService.ClearUser();
//            return (false, null, ["Your session has expired. Please log in again."]);
//        }

//        if (!response.IsSuccessStatusCode)
//            return (false, null, await ParseErrorsAsync(response));

//        var profile = await response.Content.ReadFromJsonAsync<UserProfileModel>();
//        return profile is null
//            ? (false, null, ["Email was updated, but profile data could not be read."])
//            : (true, profile, []);
//    }

//    public async Task<(bool Success, IEnumerable<string> Errors)> ChangePasswordAsync(string currentPassword, string newPassword)
//    {
//        if (!_authStateService.IsAuthenticated)
//            return (false, ["You are not logged in."]);

//        var request = CreateAuthorizedRequest(HttpMethod.Put, "api/auth/profile/password");
//        request.Content = JsonContent.Create(new { CurrentPassword = currentPassword, NewPassword = newPassword });
//        var response = await _httpClient.SendAsync(request);

//        if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
//        {
//            _authStateService.ClearUser();
//            return (false, ["Your session has expired. Please log in again."]);
//        }

//        if (!response.IsSuccessStatusCode)
//            return (false, await ParseErrorsAsync(response));

//        return (true, []);
//    }

//    private HttpRequestMessage CreateAuthorizedRequest(HttpMethod method, string url)
//    {
//        var request = new HttpRequestMessage(method, url);
//        if (_authStateService.IsAuthenticated)
//        {
//            var token = _authStateService.Token!;
//            if (token.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
//                token = token[7..].Trim();

//            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
//        }

//        return request;
//    }

//    private static async Task<IEnumerable<string>> ParseErrorsAsync(HttpResponseMessage response)
//    {
//        try
//        {
//            var json = await response.Content.ReadFromJsonAsync<JsonElement>();
//            if (json.TryGetProperty("errors", out var errorsElement))
//                return errorsElement.EnumerateArray().Select(e => e.GetString() ?? string.Empty).Where(e => !string.IsNullOrWhiteSpace(e));

//            if (json.TryGetProperty("message", out var messageElement))
//            {
//                var message = messageElement.GetString();
//                if (!string.IsNullOrWhiteSpace(message))
//                    return [message];
//            }
//        }
//        catch { }

//        return ["An unexpected error occurred. Please try again."];
//    }
//}