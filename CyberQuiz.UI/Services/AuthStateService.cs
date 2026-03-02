namespace CyberQuiz.UI.Services;

public class AuthStateService
{
    public string? Token { get; private set; }
    public string? UserName { get; private set; }
    public string? Email { get; private set; }
    public bool IsAuthenticated => !string.IsNullOrWhiteSpace(Token) && !IsTokenExpired(Token);

    public event Action? OnChange;

    public void SetUser(string token, string email, string userName)
    {
        if (IsTokenExpired(token))
        {
            ClearUser();
            return;
        }

        Token = token;
        Email = email;
        UserName = userName;
        OnChange?.Invoke();
    }

    public void ClearUser()
    {
        Token = null;
        Email = null;
        UserName = null;
        OnChange?.Invoke();
    }

    private static bool IsTokenExpired(string token)
    {
        try
        {
            var parts = token.Split('.');
            if (parts.Length < 2)
                return true;

            var payload = parts[1]
                .Replace('-', '+')
                .Replace('_', '/');

            if (payload.Length % 4 != 0)
                payload = payload.PadRight(payload.Length + (4 - payload.Length % 4), '=');

            var payloadJson = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(payload));
            using var document = System.Text.Json.JsonDocument.Parse(payloadJson);

            if (!document.RootElement.TryGetProperty("exp", out var expElement))
                return false;

            var expiresAt = DateTimeOffset.FromUnixTimeSeconds(expElement.GetInt64());
            return expiresAt <= DateTimeOffset.UtcNow;
        }
        catch
        {
            return true;
        }
    }
}
