using LanguageExt;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Kf.CANetCore31.Reflection
{
    public static class PropertyInfoHelper
    {
        /// <summary>
        /// Returns a <see cref="PropertyInfo"/> object by use of a lambda expression <paramref name="propertySelector"/>.
        /// </summary>
        /// <typeparam name="TObject">The type of the object the property comes from.</typeparam>
        /// <param name="object">The object the property is retrieved from.</param>
        /// <param name="propertySelector">The lambda expression selecting the property.</param>
        public static Option<PropertyInfo> GetPropertyInfo<TObject, TResult>(
            TObject @object,
            Expression<Func<TObject, TResult>> propertySelector)
        {
            if (!(propertySelector is Expression expression))
                return Option<PropertyInfo>.None;

            if (propertySelector is LambdaExpression lambdaExpression)
                expression = lambdaExpression.Body;

            return expression is MemberExpression memberExpression
                ? memberExpression.Member as PropertyInfo
                : Option<PropertyInfo>.None;
        }

        /// <summary>
        /// Returns the name and value (as a string representation) of a property using a lambda selector.
        /// </summary>
        /// <typeparam name="TObject">The type of the object the property comes from.</typeparam>
        /// <param name="object">The object the property is retrieved from.</param>
        /// <param name="propertySelector">The lambda expression selecting the property.</param>
        public static Option<KeyValuePair<string, string>> GetPropertyNameAndValue<TObject, TResult>(
            TObject @object,
            Expression<Func<TObject, TResult>> propertySelector)
            => @object.GetPropertyInfo(propertySelector)
                .Some(p => KeyValuePair.Create(p.Name, p.GetValue(@object)?.ToString()))
                .None(() => Null.NullKeyValuePair);
    }
}
