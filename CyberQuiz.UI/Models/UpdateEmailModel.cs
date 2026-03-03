using System.ComponentModel.DataAnnotations;

namespace CyberQuiz.UI.Models;

public class UpdateEmailModel
{
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    public string Email { get; set; } = string.Empty;
}
