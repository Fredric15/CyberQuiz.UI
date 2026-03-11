using CyberQuiz.DAL.Models;

namespace CyberQuizApi.Services
{
    public interface ITokenService
    {
        string GenerateJwtToken(ApplicationUser user);
    }
}
