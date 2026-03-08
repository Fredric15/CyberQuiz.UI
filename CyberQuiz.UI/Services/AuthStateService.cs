using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace CyberQuiz.UI.Services;

public class CustomAuthStateProvider : AuthenticationStateProvider
{
    //Alternativ 1:
    //ProtectedSessionStorage sparar Jwt-token i session-minnet,
    //Vilket innebär att den raderas när webbläsaren eller fliken stängs
    private readonly ProtectedSessionStorage _sessionStorage;

    //Alternativ 2: Spara token i localStorage (ProtectedLocalStorage)
    //ProtectedLocalStorage sparar i localStorage,
    //vilket innebär att den finns kvar även efter att webbläsaren eller fliken stängs

    public CustomAuthStateProvider(ProtectedSessionStorage sessionStorage)
    {
        _sessionStorage = sessionStorage;
    }

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        try
        {
            // Försök hämta token-strängen från session-minnet
            var tokenResult = await _sessionStorage.GetAsync<string>("authToken");
            var token = tokenResult.Success ? tokenResult.Value : null;

            if (string.IsNullOrWhiteSpace(token))
            {
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            }

            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);

            // Kolla om token har gått ut och i så fall radera den från session-minnet
            if (jwtToken.ValidTo < DateTime.UtcNow)
            {
                await _sessionStorage.DeleteAsync("authToken");
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            }

            var identity = new ClaimsIdentity(jwtToken.Claims, "jwtAuthType");
            var user = new ClaimsPrincipal(identity);

            return new AuthenticationState(user);
        }
        catch
        {
            // Fångar upp prerendering-kraschar
            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        }
    }

    public async Task MarkUserAsAuthenticated(string token)
    {
        //Denna metoden anropas av FrontendAuthService när inloggningen lyckas,
        //Och sparar token-strängen i session-minnet
        await _sessionStorage.SetAsync("authToken", token); // Spara

        var handler = new JwtSecurityTokenHandler();
        var jwtToken = handler.ReadJwtToken(token);
        var identity = new ClaimsIdentity(jwtToken.Claims, "jwtAuthType");
        var user = new ClaimsPrincipal(identity);

        NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
    }

    public async Task MarkUserAsLoggedOut()
    {
        // Denna metoden anropas av i AuthApiClient när användaren loggar ut
        await _sessionStorage.DeleteAsync("authToken"); // Radera
        var anonymous = new ClaimsPrincipal(new ClaimsIdentity());

        NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(anonymous)));
    }
}

