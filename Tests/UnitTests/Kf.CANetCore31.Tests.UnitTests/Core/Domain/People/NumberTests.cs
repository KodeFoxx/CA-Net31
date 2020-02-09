using FluentAssertions;
using Kf.CANetCore31.Core.Domain.People;
using System;
using Xunit;

namespace Kf.CANetCore31.Tests.UnitTests.Core.Domain.People
{
    public sealed class NumberTests
    {
        [Fact]
        public void Empty_Number_has_id_of_0()
            => Number.Empty.IdentificationNumber.Should().Be("0000000");

        [Theory]
        [InlineData(0, "0000000-00")]
        [InlineData(33311, "0033311-40")]
        [InlineData(134410, "0134410-65")]
        [InlineData(143471, "0143471-08")]
        [InlineData(128862, "0128862-46")]
        [InlineData(9999999, "9999999-75")]
        public void Value_is_calculated_correctly(long id, string expectedValue)
            => Number.Create(id).Value.Should().Be(expectedValue);

        [Fact]
        public void Highest_possible_value_is_7_digits()
        {
            var exception = Assert.Throws<InvalidNumberException>(
                () => Number.Create(9999999 + 1)
            );

            exception.InnerException.Should().NotBeNull();
            exception.InnerException.Should().BeOfType<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Lowest_possible_value_is_0()
        {
            var exception = Assert.Throws<InvalidNumberException>(
                () => Number.Create(-1)
            );

            exception.InnerException.Should().NotBeNull();
            exception.InnerException.Should().BeOfType<ArgumentOutOfRangeException>();
        }
    }
}
