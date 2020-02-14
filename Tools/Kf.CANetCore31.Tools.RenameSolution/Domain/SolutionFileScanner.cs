using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kf.CANetCore31.Tools.RenameSolution.Domain
{
    public static class SolutionFileScanner
    {
        private static readonly string _solutionFileExtension = ".sln";

        public static IEnumerable<Solution> Scan(
            DirectoryInfo directory,
            bool searchRecursivelyInTopDirectories = false,
            List<Solution> preExistingSolutionFiles = null)
        {
            try
            {
                if (!directory.Exists || !directory.Parent.Exists)
                    return Enumerable.Empty<Solution>();

                var solutionFiles = preExistingSolutionFiles ?? new List<Solution>();

                var potentialSolutionFiles = directory.GetFiles(
                    searchPattern: $"*{_solutionFileExtension}",
                    searchOption: SearchOption.AllDirectories);

                var foundSolutionFiles = (
                        potentialSolutionFiles.Length > 0
                        ? LoadSolutionFiles(potentialSolutionFiles).Append(solutionFiles)
                        : new List<Solution>())
                        .ToList();

                if (!searchRecursivelyInTopDirectories || foundSolutionFiles.Length() > 0)
                    return foundSolutionFiles;
                else
                    return Scan(
                        directory.Parent,
                        searchRecursivelyInTopDirectories,
                        foundSolutionFiles);
            }
            catch (Exception exception)
            {
                throw new SolutionFileScannerException(
                    $"Could not locate any solution file(s) due to an '{exception.GetType().GetTypeName()}', see innerExcpetion for more details",
                    exception);
            }
        }

        public static IEnumerable<Solution> Scan(
            string path,
            bool searchRecursivelyInTopDirectories = false)
        {
            try
            {
                var pathWithFileNameStripped = new FileInfo(path).Directory.FullName;

                if (!Directory.Exists(pathWithFileNameStripped))
                    throw new DirectoryNotFoundException(
                        $"Given path '{pathWithFileNameStripped}' is malformed, doesn't exist, or is inaccesible");

                return Scan(new DirectoryInfo(pathWithFileNameStripped), searchRecursivelyInTopDirectories);
            }
            catch (Exception exception)
            {
                throw new SolutionFileScannerException(
                    $"Could not locate any solution file(s) due to an '{exception.GetType().GetTypeName()}', see innerExcpetion for more details",
                    exception);
            }
        }

        private static List<Solution> LoadSolutionFiles(IEnumerable<FileInfo> fileInfos)
            => fileInfos
                .Select(solutionFile =>
                {
                    try { return Solution.LoadFrom(solutionFile); }
                    catch (SolutionLoadException) { return null; }
                })
                .Where(solutionFile => solutionFile != null)
                .ToList();
    }
}
