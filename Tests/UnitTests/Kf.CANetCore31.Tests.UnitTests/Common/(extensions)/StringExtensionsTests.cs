using FluentAssertions;
using Xunit;

namespace Kf.CANetCore31.Tests.UnitTests.Common._extensions_
{
    public sealed class StringExtensionsTests
    {
        [Theory]
        [InlineData(null, "isNullOrEmpty")]
        [InlineData("", "isNullOrEmpty")]
        public void IfNullOrEmptyThen_returns_true_value_when_null_or_empty(
            string @string, string expected)
            => @string.IfNullOrEmptyThen("isNullOrEmpty", "isNotNullOrEmpty")
                .Should().Be(expected);

        [Theory]
        [InlineData(" ", "isNotNullOrEmpty")]
        [InlineData("This is a full string", "isNotNullOrEmpty")]
        public void IfNullOrEmptyThen_returns_false_value_when_not_null_or_empty(
            string @string, string expected)
            => @string.IfNullOrEmptyThen("isNullOrEmpty", "isNotNullOrEmpty")
                .Should().Be(expected);

        [Theory]
        [InlineData(null, "isNullOrWhiteSpace")]
        [InlineData("", "isNullOrWhiteSpace")]
        [InlineData(" ", "isNullOrWhiteSpace")]
        public void IfNullOrWhiteSpaceThen_returns_true_value_when_null_or_whitespace(
            string @string, string expected)
            => @string.IfNullOrWhiteSpaceThen("isNullOrWhiteSpace", "isNotNullOrWhiteSpace")
                .Should().Be(expected);

        [Theory]
        [InlineData("This is a full string", "isNotNullOrWhiteSpace")]
        public void IfNullOrWhiteSpaceThen_returns_false_value_when_not_null_or_whitespace(
            string @string, string expected)
            => @string.IfNullOrWhiteSpaceThen("isNullOrWhiteSpace", "isNotNullOrWhiteSpace")
                .Should().Be(expected);
    }
}
