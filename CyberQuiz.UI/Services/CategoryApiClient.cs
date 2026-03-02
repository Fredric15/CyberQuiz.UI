using CyberQuiz.UI.Models;

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

    public async Task<IEnumerable<SubCategoryModel>> GetSubCategories(int categoryId)
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<SubCategoryModel>>($"api/categories/{categoryId}/subcategories")
            ?? Enumerable.Empty<SubCategoryModel>();
    }
}
