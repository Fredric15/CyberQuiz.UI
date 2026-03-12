using CyberQuiz.UI.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace CyberQuiz.UI.Services;

public class CategoryApiClient
{
    private readonly HttpClient _httpClient;
    private readonly ProtectedSessionStorage _sessionStorage;

    public CategoryApiClient(HttpClient httpClient, ProtectedSessionStorage sessionStorage)
    {
        _httpClient = httpClient;
        _sessionStorage = sessionStorage;
    }

    public async Task<IEnumerable<CategoryDetailModel>> GetCategoriesWithSubCategories()
    {
        try
        {
            await SetAuthHeaderAsync();
            return await _httpClient.GetFromJsonAsync<IEnumerable<CategoryDetailModel>>("api/categories/with-subcategories")
                ?? Enumerable.Empty<CategoryDetailModel>();
        }
        catch (Exception ex)
        {
            // 
            Console.Error.WriteLine($"Error fetching categories with subcategories: {ex.Message}");
            return Enumerable.Empty<CategoryDetailModel>();
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