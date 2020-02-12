using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kf.CANetCore31.Tools.RenameSolution.Domain
{
    public static class SolutionFileScanner
    {
        private static readonly string _solutionFileExtension = ".sln";

        public static IEnumerable<SolutionFile> Scan(
            DirectoryInfo directory,
            bool searchRecursivelyInTopDirectories = false,
            List<SolutionFile> preExistingSolutionFiles = null)
        {
            try
            {
                if (!directory.Exists || !directory.Parent.Exists)
                    return Enumerable.Empty<SolutionFile>();

                var solutionFiles = preExistingSolutionFiles ?? new List<SolutionFile>();

                var potentialSolutionFiles = directory.GetFiles(
                    searchPattern: $"*{_solutionFileExtension}",
                    searchOption: SearchOption.AllDirectories);

                var foundSolutionFiles = (
                        potentialSolutionFiles.Length > 0
                        ? LoadSolutionFiles(potentialSolutionFiles).Append(solutionFiles)
                        : new List<SolutionFile>())
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

        public static IEnumerable<SolutionFile> Scan(
            string path,
            bool searchRecursivelyInTopDirectories = false)
        {
            try
            {
                if (!Directory.Exists(path))
                    throw new DirectoryNotFoundException(
                        $"Given path '{path}' is malformed, doesn't exist, or is inaccesible");

                return Scan(new DirectoryInfo(path), searchRecursivelyInTopDirectories);
            }
            catch (Exception exception)
            {
                throw new SolutionFileScannerException(
                    $"Could not locate any solution file(s) due to an '{exception.GetType().GetTypeName()}', see innerExcpetion for more details",
                    exception);
            }
        }

        private static List<SolutionFile> LoadSolutionFiles(IEnumerable<FileInfo> fileInfos)
            => fileInfos
                .Select(solutionFile =>
                {
                    try { return SolutionFile.LoadFrom(solutionFile); }
                    catch (SolutionFileLoadException) { return null; }
                })
                .Where(solutionFile => solutionFile != null)
                .ToList();
    }
}
