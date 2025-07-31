using RiskRent.Domain.Entities;

namespace RiskRent.Domain.Interfaces
{
    public interface IAuthService
    {
        Task<string> GenerateJwtTokenAsync(User user);
        Task<bool> ValidatePasswordAsync(string password, string hash);
        Task<string> HashPasswordAsync(string password);
        Task<User?> AuthenticateAsync(string email, string password);
    }
}