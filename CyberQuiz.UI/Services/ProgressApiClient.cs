using System.Net.Http.Headers;
using System.Net.Http.Json;
using CyberQuiz.UI.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace CyberQuiz.UI.Services;

public class ProgressApiClient
{
    private readonly HttpClient _httpClient;
    private readonly ProtectedSessionStorage _sessionStorage;

    public ProgressApiClient(HttpClient httpClient, ProtectedSessionStorage sessionStorage)
    {
        _httpClient = httpClient;
        _sessionStorage = sessionStorage;
    }

    public async Task<IEnumerable<SubCategoryProgressModel>> GetSubCategoryProgressAsync()
    {
        await SetAuthHeaderAsync();

        try
        {
            var response = await _httpClient.GetAsync("api/progress/subcategories");

            // Om vi får 401 Unauthorized eller något annat fel, returnera bara en tom lista
            if (!response.IsSuccessStatusCode)
            {
                return Enumerable.Empty<SubCategoryProgressModel>();
            }

            return await response.Content.ReadFromJsonAsync<IEnumerable<SubCategoryProgressModel>>()
                ?? Enumerable.Empty<SubCategoryProgressModel>();
        }
        catch
        {
            return Enumerable.Empty<SubCategoryProgressModel>();
        }
    }

    public async Task<QuizSubmissionResponseModel?> SubmitQuizAsync(QuizSubmissionRequestModel requestModel)
    {
        await SetAuthHeaderAsync();

        var response = await _httpClient.PostAsJsonAsync("api/progress/subcategories/submit", requestModel);

        if (!response.IsSuccessStatusCode)
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            var errorMessage = string.IsNullOrWhiteSpace(errorContent)
                ? $"Failed to submit quiz. Status code: {(int)response.StatusCode}."
                : $"Failed to submit quiz. Status code: {(int)response.StatusCode}. Response: {errorContent}";

            throw new HttpRequestException(errorMessage);
        }

        return await response.Content.ReadFromJsonAsync<QuizSubmissionResponseModel>();
    }

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
