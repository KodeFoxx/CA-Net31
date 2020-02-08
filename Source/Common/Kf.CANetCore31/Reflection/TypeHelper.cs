using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Kf.CANetCore31.Reflection
{
    public sealed class TypeHelper
    {
        public static IEnumerable<Type> GetAllFor(Assembly assembly)
            => GetAllFor(assemblies: assembly);
        public static IEnumerable<Type> GetAllFor(params Assembly[] assemblies)
            => GetAllFor(assemblies?.AsEnumerable());
        public static IEnumerable<Type> GetAllFor(IEnumerable<Assembly> assemblies)
            => assemblies
                .IfNullThenEmpty()
                .SelectMany(assembly =>
                {
                    try
                    {
                        return assembly.GetTypes();
                    }
                    catch (ReflectionTypeLoadException reflectionTypeLoadException)
                    when (reflectionTypeLoadException.Message.Contains("Unable to load one or more of the requested types"))
                    {
                        return Enumerable.Empty<Type>();
                    }
                })
                .WhereNotNull();
    }
}
