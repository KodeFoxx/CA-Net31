using Kf.CANetCore31.Diagnostics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Kf.CANetCore31.DomainDrivenDesign
{
    /// <summary>
    /// Represents a value object.
    /// Inspiration taken from https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/implement-value-objects.
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplayString,nq}")]
    public abstract class ValueObject
        : IDebuggerDisplayString,
        IEquatable<ValueObject>
    {
        public static bool operator ==(ValueObject a, ValueObject b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(ValueObject a, ValueObject b)
            => !(a == b);

        /// <summary>
        /// Gets the fields to be taken into consideration when comparing two <see cref="ValueObject"/>s of the same type.
        /// </summary>
        protected abstract IEnumerable<object> EquatableValues { get; }

        public override bool Equals(object @object)
        {
            if (@object == null || @object.GetType() != GetType())
                return false;

            if (!(@object is ValueObject other))
                return false;

            var thisValues = EquatableValues.GetEnumerator();
            var otherValues = other.EquatableValues.GetEnumerator();

            while (thisValues.MoveNext() && otherValues.MoveNext())
            {
                if (ReferenceEquals(thisValues.Current, null) ^ ReferenceEquals(otherValues.Current, null))
                    return false;

                if (thisValues.Current != null && !thisValues.Current.Equals(otherValues.Current))
                    return false;
            }

            return !thisValues.MoveNext() && !otherValues.MoveNext();
        }

        public bool Equals(ValueObject other)
            => Equals(this, other);

        public override int GetHashCode()
            => EquatableValues
                .Select(x => x != null ? x.GetHashCode() : 0)
                .Aggregate((x, y) => x ^ y);

        public virtual string DebuggerDisplayString
            => this.CreateDebugString((nameof(GetHashCode), GetHashCode()));

        public override string ToString()
            => DebuggerDisplayString;
    }
}
