using FluentAssertions;
using Kf.CANetCore31.Tools.RenameSolution.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace Kf.CANetCore31.Tools.Tests.RenameSolution.Domain
{
    public sealed class SolutionFileTests
    {
        private static SolutionFile GetCurrentSolutionFile()
            => SolutionFileScanner.Scan(
                path: Environment.CurrentDirectory,
                searchRecursivelyInTopDirectories: true)
                .First();

        [Fact]
        public void Can_load_solution_file()
            => GetCurrentSolutionFile()
                .Should().NotBeNull();

        [Theory, MemberData(nameof(Throws_SolutionFileLoadException_when_TestData))]
        public void Throws_SolutionFileLoadException_when(
            string reason,
            Func<SolutionFile> loadingLogic,
            Type innerExceptionType)
        {
            var exception = Assert.Throws<SolutionFileLoadException>(testCode: () => loadingLogic());

            exception.InnerException.Should().NotBeNull(reason);
            exception.InnerException.GetType().Should().Be(innerExceptionType, reason);
        }

        public static IEnumerable<object[]> Throws_SolutionFileLoadException_when_TestData
            => new List<object[]>
            {
                new object[]
                {
                    "Extension is not a '.sln'",
                    new Func<SolutionFile>(() => {
                        var dllFile = Directory
                            .GetFiles(Environment.CurrentDirectory, "*.dll")
                            .First();
                        return SolutionFile.LoadFrom(dllFile);
                    }),
                    typeof(FileLoadException)
                },
                new object[]
                {
                    "File doesn't exist",
                    new Func<SolutionFile>(() => {
                        return SolutionFile.LoadFrom("x:\\SolutionThatDoesntExist.sln");
                    }),
                    typeof(FileNotFoundException)
                },
                new object[]
                {
                    "Null FileInfo is passed",
                    new Func<SolutionFile>(() => {
                        return SolutionFile.LoadFrom((FileInfo)null);
                    }),
                    typeof(ArgumentNullException)
                },
                new object[]
                {
                    "Null string is passed",
                    new Func<SolutionFile>(() => {
                        return SolutionFile.LoadFrom((string)null);
                    }),
                    typeof(ArgumentNullException)
                },
                new object[]
                {
                    "Empty string is passed",
                    new Func<SolutionFile>(() => {
                        return SolutionFile.LoadFrom("");
                    }),
                    typeof(ArgumentNullException)
                },
                new object[]
                {
                    "Whitespace string is passed",
                    new Func<SolutionFile>(() => {
                        return SolutionFile.LoadFrom(" ");
                    }),
                    typeof(ArgumentNullException)
                },
            };
    }
}
