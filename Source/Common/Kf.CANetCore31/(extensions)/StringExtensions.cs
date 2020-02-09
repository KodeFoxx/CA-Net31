using System;

namespace Kf.CANetCore31
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string @string)
            => String.IsNullOrEmpty(@string);

        public static bool IsNullOrWhiteSpace(this string @string)
            => String.IsNullOrWhiteSpace(@string);

        public static TResult IfNullOrEmptyThen<TResult>(
            this string @string,
            Func<bool, TResult> resultValueDelegate)
            => resultValueDelegate(@string.IsNullOrEmpty());

        public static TResult IfNullOrEmptyThen<TResult>(
            this string @string,
            TResult resultWhenNullOrEmptyValue,
            TResult resultWhenNotNullOrEmptyValue)
            => @string.IfNullOrEmptyThen(result => result
                ? resultWhenNullOrEmptyValue
                : resultWhenNotNullOrEmptyValue);

        public static TResult IfNullOrWhiteSpaceThen<TResult>(
            this string @string,
            Func<bool, TResult> resultValueDelegate)
            => resultValueDelegate(@string.IsNullOrWhiteSpace());

        public static string IfNullOrWhiteSpaceThen(
            this string @string,
            Func<bool, string> resultValueDelegate)
            => resultValueDelegate(@string.IsNullOrWhiteSpace());

        public static TResult IfNullOrWhiteSpaceThen<TResult>(
            this string @string,
            TResult resultWhenNullOrWhiteSpaceValue,
            TResult resultWhenNotNullOrWhiteSpaceValue)
            => @string.IfNullOrWhiteSpaceThen(result => result
                ? resultWhenNullOrWhiteSpaceValue
                : resultWhenNotNullOrWhiteSpaceValue);

        public static string IfNullOrWhiteSpaceThen(
            this string @string,
            string resultWhenNullOrWhiteSpaceValue)
            => @string.IfNullOrWhiteSpaceThen(result => result
                ? resultWhenNullOrWhiteSpaceValue
                : @string);
    }
}
