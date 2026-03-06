using CyberQuiz.UI.Models;
using System.Net.Http.Json;

namespace CyberQuiz.UI.Services;

public class QuestionApiClient
{
    private readonly HttpClient _httpClient;

    public QuestionApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<QuestionModel>> GetQuestions(int subCategoryId)
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<QuestionModel>>($"api/subcategories/{subCategoryId}/questions")
            ?? Enumerable.Empty<QuestionModel>();
    }

    //public async Task<QuizDetailsDto?> GetQuizDetailsAsync(int subCategoryId)
    //{
    //    // Endpoint expected to return a quiz DTO with questions and options
    //    return await _httpClient.GetFromJsonAsync<QuizDetailsDto>($"api/subcategories/{subCategoryId}/quiz");
    //}
}
