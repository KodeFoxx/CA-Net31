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
        {
            try
            {
                if (String.IsNullOrWhiteSpace(solutionFilePath))
                    throw new ArgumentNullException(nameof(solutionFilePath));
            }
            catch (Exception exception)
            {
                throw new SolutionFileLoadException(
                    $"Could not load solution due to an '{exception.GetType().GetTypeName()}', see innerException for more information.",
                    exception);
            }

            return LoadFrom(new FileInfo(solutionFilePath));
        }

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

                FileInfo = solutionFile;
            }
            catch (Exception exception)
            {
                throw new SolutionFileLoadException(
                    $"Could not load solution due to an '{exception.GetType().GetTypeName()}', see innerException for more information.",
                    exception);
            }
        }
        private SolutionFile()
            => FileInfo = null;

        private readonly string _solutionFileExtension = ".sln";

        public FileInfo FileInfo { get; }

        protected override IEnumerable<object> EquatableValues
            => throw new System.NotImplementedException();
    }
}
