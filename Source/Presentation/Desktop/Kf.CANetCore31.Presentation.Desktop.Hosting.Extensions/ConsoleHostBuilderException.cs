using System;

namespace Kf.CANetCore31.Presentation.Desktop.Hosting.Extensions
{
    public sealed class ConsoleHostBuilderException : Exception
    {
        public ConsoleHostBuilderException(
            string message)
            : base(message)
        { }

        public ConsoleHostBuilderException(
            string message,
            Exception innerException)
            : base(message, innerException)
        { }
    }
}
