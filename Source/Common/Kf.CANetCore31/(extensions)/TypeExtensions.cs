using Kf.CANetCore31.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kf.CANetCore31
{
    public static class TypeExtensions
    {
        public static IEnumerable<Type> WhereNotNull(
            this IEnumerable<Type> types)
            => types.Where(type => type != null);

        public static string GetTypeName(
            this Type type)
            => DebugHelper.FormatTypeName(type);
    }
}
