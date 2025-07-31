using RiskRent.Domain.Exceptions;

namespace RiskRent.Application.Exceptions
{
    public class UserAlreadyExistsException : BaseException
    {
        public UserAlreadyExistsException(string email)
            : base($"Usuário com email {email} já existe", "USER_ALREADY_EXISTS", new { Email = email })
        {
        }
    }
}