using CyberQuiz.UI.Models;
using System.Text.Json.Serialization;

namespace CyberQuiz.UI.Services
{
    public record AiTutorMessage(string Role, string Content);

    public class AiTutorApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _model;

        public AiTutorApiClient(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _model = configuration["Ollama:Model"] ?? "llama3.1:8b";
        }

        public async Task<string> GetQuestionHelpAsync(
            QuestionModel question,
            IEnumerable<AiTutorMessage> conversation,
            string? userPrompt = null,
            AnswerOptionModel? selectedAnswer = null,
            bool selectedAnswerWasWrong = false,
            CancellationToken cancellationToken = default)
        {
            var optionLines = question.Options
                .Select((option, index) => $"{index + 1}. {option.Text}")
                .ToArray();

            var selectedAnswerText = selectedAnswer is null
                ? "None selected yet"
                : selectedAnswer.Text;

            var prompt = userPrompt;
            if (string.IsNullOrWhiteSpace(prompt))
            {
                prompt = selectedAnswerWasWrong
                    ? "The user just selected a wrong answer. Explain why it is incorrect and coach them toward the right reasoning without revealing test-only spoilers beyond what helps learning."
                    : "Explain this question clearly and help the user reason about the correct answer.";
            }

            var messages = new List<OllamaMessage>
        {
            new("system", "You are a helpful cybersecurity quiz tutor. Keep answers concise, supportive, and educational.IMPORTANT! never give the correct answer if the user asks for it. But you can give some clues"),
            new("user", $"Question: {question.Text}\nAnswer options:\n{string.Join("\n", optionLines)}\nSelected answer: {selectedAnswerText}\nSelected answer was wrong: {selectedAnswerWasWrong}\nInstruction: {prompt}")
        };

            messages.AddRange(conversation
                .Where(m => !string.IsNullOrWhiteSpace(m.Content))
                .Select(m => new OllamaMessage(m.Role, m.Content)));

            var request = new OllamaChatRequest
            {
                Model = _model,
                Messages = messages,
                Stream = false
            };

            using var httpRequest = new HttpRequestMessage(HttpMethod.Post, "chat");
            httpRequest.Content = JsonContent.Create(request);

            using var response = await _httpClient.SendAsync(httpRequest, cancellationToken);
            var responseBody = await response.Content.ReadFromJsonAsync<OllamaChatResponse>(cancellationToken);

            if (!response.IsSuccessStatusCode)
            {
                var error = responseBody?.Error;
                throw new HttpRequestException(string.IsNullOrWhiteSpace(error)
                    ? $"Ollama request failed with status code {(int)response.StatusCode}."
                    : error);
            }

            return responseBody?.Message?.Content?.Trim()
                ?? "I couldn't generate a response right now. Please try again.";
        }

        private sealed class OllamaChatRequest
        {
            [JsonPropertyName("model")]
            public string Model { get; set; } = string.Empty;

            [JsonPropertyName("messages")]
            public IEnumerable<OllamaMessage> Messages { get; set; } = [];

            [JsonPropertyName("stream")]
            public bool Stream { get; set; }
        }

        private sealed class OllamaMessage
        {
            public OllamaMessage(string role, string content)
            {
                Role = role;
                Content = content;
            }

            [JsonPropertyName("role")]
            public string Role { get; set; }

            [JsonPropertyName("content")]
            public string Content { get; set; }
        }

        private sealed class OllamaChatResponse
        {
            [JsonPropertyName("message")]
            public OllamaMessage? Message { get; set; }

            [JsonPropertyName("error")]
            public string? Error { get; set; }
        }
    }

}
