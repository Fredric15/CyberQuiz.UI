using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.BLL.Models
{
    public class LoginResponse
    {
        public string Token { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
    }
}
