using CyberQuiz.UI.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace CyberQuiz.UI.Services;

public class QuestionApiClient
{
    private readonly HttpClient _httpClient;
    private readonly ProtectedSessionStorage _sessionStorage;

    public QuestionApiClient(HttpClient httpClient, ProtectedSessionStorage sessionStorage)
    {
        _httpClient = httpClient;
        _sessionStorage = sessionStorage;
    }

    public async Task<IEnumerable<QuestionModel>> GetQuestions(int subCategoryId)
    {
        try
        {
            await SetAuthHeaderAsync();
            return await _httpClient.GetFromJsonAsync<IEnumerable<QuestionModel>>($"api/subcategories/{subCategoryId}/questions")
                ?? Enumerable.Empty<QuestionModel>();
        }
        catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.Unauthorized)
        {
            // Fångar upp 401-kraschen vid F5-uppdateringar och returnerar en tom lista tyst
            return Enumerable.Empty<QuestionModel>();
        }

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
