using System.Collections.Generic;
using System.Linq;

namespace Kf.CANetCore31
{
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Returns the targetted <paramref name="enumerable"/>, or an empty <see cref="IEnumerable{T}"/> when <paramref name="enumerable"/> is null.
        /// </summary>
        /// <typeparam name="TObject">The type of tyhe objects in the <see cref="IEnumerable{T}"/>.</typeparam>
        /// <param name="enumerable">The <see cref="IEnumerable{T}"/> being targetted.</param>
        public static IEnumerable<TObject> IfNullThenEmpty<TObject>(
            this IEnumerable<TObject> enumerable)
            => enumerable ?? Enumerable.Empty<TObject>();
    }
}
