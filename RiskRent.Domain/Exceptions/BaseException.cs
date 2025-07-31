using System;

namespace RiskRent.Domain.Exceptions
{
    public abstract class BaseException : Exception
    {
        public string ErrorCode { get; }
        public object? Details { get; }

        protected BaseException(string message, string errorCode, object? details = null) 
            : base(message)
        {
            ErrorCode = errorCode;
            Details = details;
        }

        protected BaseException(string message, string errorCode, Exception innerException, object? details = null) 
            : base(message, innerException)
        {
            ErrorCode = errorCode;
            Details = details;
        }
    }
}