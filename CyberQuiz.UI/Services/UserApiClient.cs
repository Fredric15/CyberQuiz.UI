using System.Net.Http.Json;
using CyberQuiz.UI.Models;

namespace CyberQuiz.UI.Services;

public class UserApiClient
{
    private readonly HttpClient _http;
    private readonly AuthStateService _auth;

    public UserApiClient(HttpClient http, AuthStateService auth)
    {
        _http = http;
        _auth = auth;
    }

    public async Task<bool> ChangeUserNameAsync(string newUserName)
    {
        if (!_auth.IsAuthenticated)
            return false;

        var response = await _http.PutAsJsonAsync("api/user/change-username", new { NewUserName = newUserName });

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> ChangePasswordAsync(string currentPassword, string newPassword)
    {
        if (!_auth.IsAuthenticated)
            return false;

        var response = await _http.PutAsJsonAsync("api/user/change-password", new
        {
            CurrentPassword = currentPassword,
            NewPassword = newPassword
        });

        return response.IsSuccessStatusCode;
    }

    public async Task<UserStatsModel?> GetUserStatsAsync()
    {
        if (!_auth.IsAuthenticated)
            return null;

        return await _http.GetFromJsonAsync<UserStatsModel>("api/user/stats");
    }
}
