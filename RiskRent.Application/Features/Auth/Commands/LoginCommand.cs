using MediatR;
using RiskRent.Application.Features.Auth.DTOs;

namespace RiskRent.Application.Features.Auth.Commands
{
    public class LoginCommand : IRequest<LoginResponseDto>
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public LoginCommand(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}