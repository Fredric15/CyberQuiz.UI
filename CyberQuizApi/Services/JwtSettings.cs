namespace CyberQuizApi.Services
{
    //Speglar de inställningar som krävs för att generera och validera JWT-tokens
    //Dessa inställningar läses in från appsettings.json och används av TokenService och i Program.cs
    public class JwtSettings
    {
        public string SecretKey { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
        public int ExpirationMinutes { get; set; }
    }
}
