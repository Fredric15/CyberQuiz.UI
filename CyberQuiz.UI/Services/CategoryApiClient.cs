using CyberQuiz.UI.Models;
using System.Net.Http.Json;

namespace CyberQuiz.UI.Services;

public class CategoryApiClient
{
    private readonly HttpClient _httpClient;

    public CategoryApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<CategoryModel>> GetCategories()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<CategoryModel>>("api/categories")
            ?? Enumerable.Empty<CategoryModel>();
    }

    public async Task<IEnumerable<CategoryDetailModel>> GetCategoriesWithSubCategories()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<CategoryDetailModel>>("api/categories/with-subcategories")
            ?? Enumerable.Empty<CategoryDetailModel>();
    }

    // 🔥 Den metod som SubCategories.razor anropar
    public async Task<IEnumerable<SubCategoryModel>> GetSubCategoriesAsync(int categoryId)
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<SubCategoryModel>>(
            $"api/categories/{categoryId}/subcategories")
            ?? Enumerable.Empty<SubCategoryModel>();
    }
}