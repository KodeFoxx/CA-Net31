using FluentAssertions;
using Kf.CANetCore31.Tools.RenameSolution.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace Kf.CANetCore31.Tools.Tests.RenameSolution.Domain
{
    public sealed class SolutionTests
    {
        private static Solution GetCurrentSolutionFile()
            => SolutionFileScanner.Scan(
                path: Environment.CurrentDirectory,
                searchRecursivelyInTopDirectories: true)
                .First();

        [Fact]
        public void Can_load_solution()
        {
            var solution = GetCurrentSolutionFile();

            solution.Should().NotBeNull();
            solution.FileInfo.Should().NotBeNull();

            var solutionFile = solution.SolutionFile;
            solutionFile.Should().NotBeNull();
            solutionFile.ProjectsByGuid.Should().NotBeEmpty();
            solutionFile.SolutionConfigurations
                .Select(sc => sc.ConfigurationName.ToLowerInvariant())
                .Should().Contain("release")
                .And.Subject.Should().Contain("debug");
        }

        [Theory, MemberData(nameof(Throws_SolutionFileLoadException_when_TestData))]
        public void Throws_SolutionFileLoadException_when(
            string reason,
            Func<Solution> loadingLogic,
            Type innerExceptionType)
        {
            var exception = Assert.Throws<SolutionLoadException>(testCode: () => loadingLogic());

            exception.InnerException.Should().NotBeNull(reason);
            exception.InnerException.GetType().Should().Be(innerExceptionType, reason);
        }

        public static IEnumerable<object[]> Throws_SolutionFileLoadException_when_TestData
            => new List<object[]>
            {
                new object[]
                {
                    "Extension is not a '.sln'",
                    new Func<Solution>(() => {
                        var dllFile = Directory
                            .GetFiles(Environment.CurrentDirectory, "*.dll")
                            .First();
                        return Solution.LoadFrom(dllFile);
                    }),
                    typeof(FileLoadException)
                },
                new object[]
                {
                    "File doesn't exist",
                    new Func<Solution>(() => {
                        return Solution.LoadFrom("x:\\SolutionThatDoesntExist.sln");
                    }),
                    typeof(FileNotFoundException)
                },
                new object[]
                {
                    "Null FileInfo is passed",
                    new Func<Solution>(() => {
                        return Solution.LoadFrom((FileInfo)null);
                    }),
                    typeof(ArgumentNullException)
                },
                new object[]
                {
                    "Null string is passed",
                    new Func<Solution>(() => {
                        return Solution.LoadFrom((string)null);
                    }),
                    typeof(ArgumentNullException)
                },
                new object[]
                {
                    "Empty string is passed",
                    new Func<Solution>(() => {
                        return Solution.LoadFrom("");
                    }),
                    typeof(ArgumentNullException)
                },
                new object[]
                {
                    "Whitespace string is passed",
                    new Func<Solution>(() => {
                        return Solution.LoadFrom(" ");
                    }),
                    typeof(ArgumentNullException)
                },
            };
    }
}
