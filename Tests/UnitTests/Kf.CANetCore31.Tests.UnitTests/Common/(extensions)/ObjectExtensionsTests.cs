using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace Kf.CANetCore31.Tests.UnitTests.Common._extensions_
{
    public sealed class ObjectExtensionsTests
    {
        [Fact]
        public void GetPropertyNameAndValue_returns_the_name_and_value_of_the_property()
        {
            var stringObject = "stringObject";

            var sut = stringObject.GetPropertyNameAndValue(p => p.Length)
                .Some(v => v)
                .None(Null.NullKeyValuePair);

            sut.Should().NotBeNull();
            sut.Key.Should().Be(nameof(stringObject.Length));
            sut.Value.Should().Be(stringObject.Length.ToString());
        }

        [Fact]
        public void GetPropertyNameAndValue_returns_NullKeyValuePair_when_not_found()
        {
            var stringObject = "stringObject";

            var sut = stringObject.GetPropertyNameAndValue<string, object>(null)
                .Some(v => v)
                .None(Null.NullKeyValuePair);

            sut.Should().NotBeNull();
            sut.Should().Be(Null.NullKeyValuePair);
        }

        [Fact]
        public void GetPropertyName_returns_the_name_of_the_property()
        {
            var stringObject = "stringObject";

            var sut = stringObject.GetPropertyName(p => p.Length);

            sut.IsNullOrWhiteSpace().Should().BeFalse();
            sut.Should().Be(nameof(stringObject.Length));
        }

        [Fact]
        public void GetPropertyName_returns_empty_string_when_not_found()
        {
            var stringObject = "stringObject";

            var sut = stringObject.GetPropertyName<string, object>(null);

            sut.IsNullOrWhiteSpace().Should().BeTrue();
            sut.Should().Be(String.Empty);
        }

        [Theory, MemberData(nameof(CreateDebugString_with_expressions_creates_correct_string_TestData))]
        public void CreateDebugString_with_expressions_creates_correct_string(
            string actual, string expected)
            => actual
                .Should().Be(expected);

        public static IEnumerable<object[]> CreateDebugString_with_expressions_creates_correct_string_TestData()
            => new List<object[]>
            {
                new object[] {
                    KeyValuePair.Create("key", "value")
                        .CreateDebugString(kvp => kvp.Key, kvp => kvp.Value),
                    "KeyValuePair<String, String> -> [ Key='key', Value='value' ]"
                },
                new object[] {
                    KeyValuePair.Create("key", (string)null)
                        .CreateDebugString(kvp => kvp.Key, kvp => kvp.Value),
                    $"KeyValuePair<String, String> -> [ Key='key', Value='' ]"
                },
                new object[] {
                    KeyValuePair.Create("key", KeyValuePair.Create("number", 1))
                        .CreateDebugString(kvp => kvp.Key),
                    $"KeyValuePair<String, KeyValuePair<String, Int32>> -> [ Key='key' ]"
                },
                new object[] {
                    new Exception("message", null)
                        .CreateDebugString(ex => ex.Message, ex => ex.InnerException),
                    $"Exception -> [ Message='message', InnerException='' ]"
                }
            };
    }
}
