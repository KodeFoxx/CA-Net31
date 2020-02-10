using Kf.CANetCore31.DomainDrivenDesign;
using System.Diagnostics;

namespace Kf.CANetCore31.Core.Domain.People
{
    /// <summary>
    /// Defines a person.
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplayString,nq}")]
    public sealed class Person : Entity
    {
        public static Person Empty
            => new Person();

        public static Person Create(Name name)
            => new Person(name);

        public static Person Create(long id, Name name)
            => new Person(id, name);

        private Person(long id, Name name)
            : base(id)
            => Name = name;
        private Person(Name name)
            : this(0, name)
        { }
        private Person()
            : this(Name.Empty)
        { }

        public Number Number
            => Number.For(this);
        public Name Name { get; }

        public override string DebuggerDisplayString
            => this.CreateDebugString(x => x.Number.Value, x => x.Name);
    }
}
