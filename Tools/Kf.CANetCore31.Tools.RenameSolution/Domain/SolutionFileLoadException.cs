using System;

namespace Kf.CANetCore31.Tools.RenameSolution.Domain
{
    public sealed class SolutionFileLoadException : Exception
    {
        public SolutionFileLoadException(string message)
            : base(message)
        { }

        public SolutionFileLoadException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}