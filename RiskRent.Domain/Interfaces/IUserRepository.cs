using RiskRent.Domain.Entities;
using RiskRent.Domain.Pagination;

namespace RiskRent.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(int id);
        Task<User?> GetByEmailAsync(string email);
        Task<PageList<User>> GetAllAsync(PageParams pageParams);
        Task<User> CreateAsync(User user);
        Task<User> UpdateAsync(User user);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(string email);
    }
}