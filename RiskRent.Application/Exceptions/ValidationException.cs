using RiskRent.Domain.Exceptions;

namespace RiskRent.Application.Exceptions
{
    public class ValidationException : BaseException
    {
        public IDictionary<string, string[]> Errors { get; }

        public ValidationException(IDictionary<string, string[]> errors)
            : base("Erro de validação", "VALIDATION_ERROR", errors)
        {
            Errors = errors;
        }

        public ValidationException(string field, string error)
            : base($"Erro de validação no campo {field}", "VALIDATION_ERROR")
        {
            Errors = new Dictionary<string, string[]>
            {
                { field, new[] { error } }
            };
        }
    }
}