using System.Collections.Generic;
using System.Diagnostics;

namespace Kf.CANetCore31.DomainDrivenDesign
{
    /// <summary>
    /// Represents an id.
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplayString,nq}")]
    public sealed class Id : ValueObject
    {
        public static implicit operator Id(long value)
            => new Id(value);
        public static implicit operator long(Id value)
            => value.Value;
        public static implicit operator Id(ulong value)
            => new Id((long)value);
        public static implicit operator ulong(Id value)
            => (ulong)value.Value;
        public static implicit operator int(Id value)
            => (int)value.Value;

        public static Id Empty
            => new Id();

        public static Id Create(long value)
            => new Id(value);

        private Id(long id)
            => Value = id;
        private Id()
            : this(0)
        { }

        public long Value { get; }

        public override string DebuggerDisplayString
            => this.CreateDebugString(x => x.Value);

        public override string ToString()
            => DebuggerDisplayString;

        protected override IEnumerable<object> EquatableValues
            => new object[] { Value };
    }
}