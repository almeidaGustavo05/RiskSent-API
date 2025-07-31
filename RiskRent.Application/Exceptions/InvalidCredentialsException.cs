using RiskRent.Domain.Exceptions;

namespace RiskRent.Application.Exceptions
{
    public class InvalidCredentialsException : BaseException
    {
        public InvalidCredentialsException()
            : base("Email ou senha inválidos", "INVALID_CREDENTIALS")
        {
        }

        public InvalidCredentialsException(string email)
            : base($"Credenciais inválidas para o email {email}", "INVALID_CREDENTIALS", new { Email = email })
        {
        }
    }
}