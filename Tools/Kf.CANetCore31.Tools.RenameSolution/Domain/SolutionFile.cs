using Kf.CANetCore31.DomainDrivenDesign;
using System;
using System.Collections.Generic;
using System.IO;

namespace Kf.CANetCore31.Tools.RenameSolution.Domain
{
    public sealed class SolutionFile : ValueObject
    {
        public SolutionFile Empty
            => new SolutionFile();

        public static SolutionFile LoadFrom(FileInfo fileInfo)
            => new SolutionFile(fileInfo);
        public static SolutionFile LoadFrom(string solutionFilePath)
            => new SolutionFile(solutionFilePath);

        private SolutionFile(FileInfo solutionFile)
        {
            try
            {
                if (solutionFile == null)
                    throw new ArgumentNullException(nameof(solutionFile));

                if (!solutionFile.Exists)
                    throw new FileNotFoundException(
                        $"No file found at path '{solutionFile.FullName}'.",
                        solutionFile.FullName);

                if (solutionFile.Extension.ToLower() != _solutionFileExtension)
                    throw new FileLoadException(
                        $"The file found at '{solutionFile.FullName}' does not have the correct extension, expected '.sln' but found '{solutionFile.Extension}'.",
                        solutionFile.FullName);

                _solutionFile = solutionFile;
            }
            catch (Exception exception)
            {
                throw new SolutionFileLoadException(
                    $"Could not load solution due to an '{exception.GetType().GetTypeName()}', see innerException for more information.",
                    exception);
            }
        }
        private SolutionFile(string solutionFilePath)
            : this(new FileInfo(solutionFilePath))
        { }
        private SolutionFile()
            => _solutionFile = null;

        private readonly string _solutionFileExtension = ".sln";
        private readonly FileInfo _solutionFile;

        protected override IEnumerable<object> EquatableValues
            => throw new System.NotImplementedException();
    }
}
