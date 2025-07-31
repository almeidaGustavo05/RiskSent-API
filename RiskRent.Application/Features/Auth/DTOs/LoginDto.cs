using System.ComponentModel.DataAnnotations;

namespace RiskRent.Application.Features.Auth.DTOs
{
    public class LoginDto
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}