using CyberQuiz.UI.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace CyberQuiz.UI.Services;

public class UserApiClient
{
    private readonly HttpClient _httpClient;
    private readonly ProtectedSessionStorage _sessionStorage;

    public UserApiClient(HttpClient httpClient, ProtectedSessionStorage sessionStorage)
    {
        _httpClient = httpClient;
        _sessionStorage = sessionStorage;
    }

    public async Task<(bool Success, UserProfileModel? Profile, string? Error)> GetProfileAsync()
    {
        try
        {
            await SetAuthHeaderAsync();
            var response = await _httpClient.GetAsync("api/auth/profile");

            if (response.IsSuccessStatusCode)
            {
                var profile = await response.Content.ReadFromJsonAsync<UserProfileModel>();
                return (true, profile, null);
            }
            return (false, null, "Kunde inte hämta profilen.");
        }
        catch (Exception ex)
        {
            return (false, null, ex.Message);
        }
    }

    public async Task<(bool Success, string? Error)> UpdateEmailAsync(string newEmail)
    {
        await SetAuthHeaderAsync();
        var response = await _httpClient.PutAsJsonAsync("api/auth/profile/email", new { Email = newEmail });
        return response.IsSuccessStatusCode ? (true, null) : (false, "Kunde inte uppdatera e-post.");
    }

    public async Task<(bool Success, string? Error)> ChangePasswordAsync(string currentPwd, string newPwd)
    {
        await SetAuthHeaderAsync();
        var response = await _httpClient.PutAsJsonAsync("api/auth/profile/password",
            new { CurrentPassword = currentPwd, NewPassword = newPwd });
        return response.IsSuccessStatusCode ? (true, null) : (false, "Lösenordsbyte misslyckades.");
    }

    //public async Task<bool> ChangeUserNameAsync(string newUserName)
    //{
    //    if (!_auth.IsAuthenticated)
    //        return false;

    //    var response = await _http.PutAsJsonAsync("api/user/change-username", new { NewUserName = newUserName });

    //    return response.IsSuccessStatusCode;
    //}

    //public async Task<bool> ChangePasswordAsync(string currentPassword, string newPassword)
    //{
    //    if (!_auth.IsAuthenticated)
    //        return false;

    //    var response = await _http.PutAsJsonAsync("api/user/change-password", new
    //    {
    //        CurrentPassword = currentPassword,
    //        NewPassword = newPassword
    //    });

    //    return response.IsSuccessStatusCode;
    //}

    //public async Task<UserStatsModel?> GetUserStatsAsync()
    //{
    //    if (!_auth.IsAuthenticated)
    //        return null;

    //    return await _http.GetFromJsonAsync<UserStatsModel>("api/user/stats");
    //}

    //Hjälpmetod för att sätta token i headern innan varje anrop som kräver autentisering
    private async Task SetAuthHeaderAsync()
    {
        try
        {
            var result = await _sessionStorage.GetAsync<string>("authToken");
            if (result.Success && !string.IsNullOrEmpty(result.Value))
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", result.Value);
            }
        }
        catch (InvalidOperationException)
        {
            //Fångar kraschen när Blazor försöker läsa från sessionStorage under server-side rendering,
            //När JavaScript inte har hunnit starta än.
        }
    }
}
