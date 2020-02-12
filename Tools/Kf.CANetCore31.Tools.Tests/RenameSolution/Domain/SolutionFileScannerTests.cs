using FluentAssertions;
using Kf.CANetCore31.Tools.RenameSolution.Domain;
using System;
using Xunit;

namespace Kf.CANetCore31.Tools.Tests.RenameSolution.Domain
{
    public sealed class SolutionFileScannerTests
    {
        [Fact]
        public void Can_find_containing_solution()
            => SolutionFileScanner.Scan(
                path: Environment.CurrentDirectory,
                searchRecursivelyInTopDirectories: true)
                .Should().HaveCount(1);

        [Fact]
        public void Returns_empty_collection_when_no_solutions_are_found()
            => SolutionFileScanner.Scan(
                path: Environment.CurrentDirectory,
                searchRecursivelyInTopDirectories: false)
                .Should().HaveCount(0);
    }
}
