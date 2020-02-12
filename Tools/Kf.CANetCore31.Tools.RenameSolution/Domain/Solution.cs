using Kf.CANetCore31.DomainDrivenDesign;
using Microsoft.Build.Construction;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kf.CANetCore31.Tools.RenameSolution.Domain
{
    public sealed class Solution : ValueObject
    {
        public Solution Empty
            => new Solution();

        public static Solution LoadFrom(FileInfo fileInfo)
            => new Solution(fileInfo);
        public static Solution LoadFrom(string solutionFilePath)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(solutionFilePath))
                    throw new ArgumentNullException(nameof(solutionFilePath));
            }
            catch (Exception exception)
            {
                throw new SolutionLoadException(
                    $"Could not load solution due to an '{exception.GetType().GetTypeName()}', see innerException for more information.",
                    exception);
            }

            return LoadFrom(new FileInfo(solutionFilePath));
        }

        private Solution(FileInfo solutionFile)
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
                SolutionFile = SolutionFile.Parse(FileInfo.FullName);
            }
            catch (Exception exception)
            {
                throw new SolutionLoadException(
                    $"Could not load solution due to an '{exception.GetType().GetTypeName()}', see innerException for more information.",
                    exception);
            }
        }
        private Solution()
        {
            FileInfo = null;
            SolutionFile = null;
        }

        private readonly string _solutionFileExtension = ".sln";

        public FileInfo FileInfo { get; }
        public SolutionFile SolutionFile { get; }
        public IEnumerable<ProjectInSolution> Projects
            => SolutionFile?.ProjectsInOrder ?? Enumerable.Empty<ProjectInSolution>();

        protected override IEnumerable<object> EquatableValues
            => throw new System.NotImplementedException();
    }
}
