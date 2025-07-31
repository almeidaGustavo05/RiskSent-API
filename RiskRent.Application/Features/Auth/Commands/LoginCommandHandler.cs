using MediatR;
using Microsoft.Extensions.Configuration;
using RiskRent.Application.Features.Auth.DTOs;
using RiskRent.Application.Exceptions;
using RiskRent.Domain.Interfaces;

namespace RiskRent.Application.Features.Auth.Commands
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginResponseDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthService _authService;
        private readonly IConfiguration _configuration;

        public LoginCommandHandler(
            IUnitOfWork unitOfWork, 
            IAuthService authService,
            IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _authService = authService;
            _configuration = configuration;
        }

        public async Task<LoginResponseDto> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _authService.AuthenticateAsync(request.Email, request.Password);
            
            if (user == null)
                throw new InvalidCredentialsException(request.Email);

            var token = await _authService.GenerateJwtTokenAsync(user);
            
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var expiryMinutes = int.Parse(jwtSettings["ExpiryMinutes"] ?? "60");

            return new LoginResponseDto
            {
                Token = token,
                UserId = user.Id,
                Email = user.Email,
                Name = user.Name,
                Role = user.Role,
                ExpiresAt = DateTime.UtcNow.AddMinutes(expiryMinutes)
            };
        }
    }
}