using System;

namespace Kf.CANetCore31.Tools.RenameSolution.Domain
{
    public sealed class SolutionLoadException : Exception
    {
        public SolutionLoadException(string message)
            : base(message)
        { }

        public SolutionLoadException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}