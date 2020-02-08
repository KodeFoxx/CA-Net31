using Kf.CANetCore31.Reflection;
using LanguageExt;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Kf.CANetCore31
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// Returns a <see cref="PropertyInfo"/> object by use of a lambda expression <paramref name="propertySelector"/>.
        /// </summary>
        /// <typeparam name="TObject">The type of the object the property comes from.</typeparam>
        /// <param name="object">The object the property is retrieved from.</param>
        /// <param name="propertySelector">The lambda expression selecting the property.</param>
        public static Option<PropertyInfo> GetPropertyInfo<TObject, TResult>(
            this TObject @object,
            Expression<Func<TObject, TResult>> propertySelector)
            => PropertyInfoHelper.GetPropertyInfo(@object, propertySelector);

        /// <summary>
        /// Returns the name and value (as a string representation) of a property using a lambda selector.
        /// </summary>
        /// <typeparam name="TObject">The type of the object the property comes from.</typeparam>
        /// <param name="object">The object the property is retrieved from.</param>
        /// <param name="propertySelector">The lambda expression selecting the property.</param>
        public static Option<KeyValuePair<string, string>> GetPropertyNameAndValue<TObject, TResult>(
            this TObject @object,
            Expression<Func<TObject, TResult>> propertySelector)
            => PropertyInfoHelper.GetPropertyNameAndValue(@object, propertySelector);

        /// <summary>
        /// Returns the <see cref="PropertyInfo"/> using a lambda selector.
        /// </summary>
        /// <typeparam name="TObject">The type of the object the property comes from.</typeparam>
        /// <param name="object">The object the property is retrieved from.</param>
        /// <param name="propertySelector">The lambda expression selecting the property.</param>
        public static string GetPropertyName<TObject, TResult>(
            this TObject @object,
            Expression<Func<TObject, TResult>> propertySelector)
            => PropertyInfoHelper.GetPropertyName(@object, propertySelector);
    }
}
