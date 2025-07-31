using RiskRent.Domain.Exceptions;

namespace RiskRent.Application.Exceptions
{
    public class UserNotFoundException : BaseException
    {
        public UserNotFoundException(int userId)
            : base($"Usuário com ID {userId} não foi encontrado", "USER_NOT_FOUND", new { UserId = userId })
        {
        }

        public UserNotFoundException(string email)
            : base($"Usuário com email {email} não foi encontrado", "USER_NOT_FOUND", new { Email = email })
        {
        }
    }
}