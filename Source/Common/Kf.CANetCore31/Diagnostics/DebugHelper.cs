using LanguageExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Kf.CANetCore31.Diagnostics
{
    public static class DebugHelper
    {
        /// <summary>
        /// Creates a debug string.
        /// </summary>
        public static string CreateDebugString(
            object @this,
            params (string Variable, Option<object> Value)[] variablesAndValues
        )
            => (variablesAndValues ?? Array.Empty<(string Variable, Option<object> Value)>())
                .Select(vv => Option<KeyValuePair<string, string>>.Some(
                    KeyValuePair.Create(
                        key: vv.Variable,
                        value: vv.Value.Some(x => x.ToString()).None(() => Null.NullString)))
                )
                .FormatDebugString(@this.GetType());

        /// <summary>
        /// Creates a debug string.
        /// </summary>
        public static string CreateDebugString<TObject>(
            TObject @this,
            params Expression<Func<TObject, object>>[] propertySelectors
        )
            => (propertySelectors ?? Array.Empty<Expression<Func<TObject, object>>>())
                .Select(ps => @this.GetPropertyNameAndValue(ps))
                .FormatDebugString(@this.GetType());

        /// <summary>
        /// Holds the logic on how to format a debug string.
        /// </summary>
        /// <param name="namesAndValues">Collection of property names with their values.</param>
        /// <param name="type">The type of the object.</param>
        private static string FormatDebugString(
            this IEnumerable<Option<KeyValuePair<string, string>>> namesAndValues,
            Type type
        )
            => $"{FormatTypeName(type)} -> [ {FormatNamesAndValues(namesAndValues)} ]";

        /// <summary>
        /// Holds the logic on how to format the name of a type in a human readible format.
        /// </summary>
        public static string FormatTypeName(Type type)
        {
            if (!type.IsGenericType) return type.Name;

            var typeName = type.Name;
            var typeGenericArguments = type.GetGenericArguments();

            var stringBuilder = new StringBuilder();

            stringBuilder.Append(typeName.Substring(0, typeName.LastIndexOf('`')));
            stringBuilder.Append(typeGenericArguments.Aggregate(
                seed: "<",
                func: (aggregate, enclosedType)
                    => $"{aggregate}{(aggregate == "<" ? String.Empty : ", ")}{FormatTypeName(enclosedType)}"
                )
            );
            stringBuilder.Append(">");

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Holds the logic on how to format the name and value pair of a property.
        /// </summary>
        private static string FormatNamesAndValues(IEnumerable<Option<KeyValuePair<string, string>>> namesAndValues)
            => String.Join(
                separator: ", ",
                values: namesAndValues
                    .Somes()
                    .Select(nv => $"{nv.Key}='{nv.Value}'"
                )
            );
    }
}
