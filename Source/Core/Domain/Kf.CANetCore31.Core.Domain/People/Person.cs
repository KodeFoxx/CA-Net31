using Kf.CANetCore31.DomainDrivenDesign;
using System.Diagnostics;

namespace Kf.CANetCore31.Core.Domain.People
{
    [DebuggerDisplay("{DebuggerDisplayString,nq}")]
    public sealed class Person : Entity
    {
        public static Person Empty
            => new Person();

        public static Person Create(long id)
            => new Person(id);

        private Person(long id)
            : base(id)
        { }
        private Person()
            : this(0)
        { }

        public Number Number
            => Number.For(this);

        public override string DebuggerDisplayString
            => this.CreateDebugString(x => x.Id);
    }
}
