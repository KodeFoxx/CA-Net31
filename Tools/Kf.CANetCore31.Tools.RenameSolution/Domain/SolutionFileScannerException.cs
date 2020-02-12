using System;

namespace Kf.CANetCore31.Tools.RenameSolution.Domain
{
    public sealed class SolutionFileScannerException : Exception
    {
        public SolutionFileScannerException(string message)
            : base(message)
        { }

        public SolutionFileScannerException(
            string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}