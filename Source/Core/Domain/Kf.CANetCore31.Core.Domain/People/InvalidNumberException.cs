using System;

namespace Kf.CANetCore31.Core.Domain.People
{
    public sealed class InvalidNumberException : Exception
    {
        public InvalidNumberException(string message)
            : base(message, null)
        { }

        public InvalidNumberException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}