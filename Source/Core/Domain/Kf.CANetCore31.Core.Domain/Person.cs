using Kf.CANetCore31.DomainDrivenDesign;
using System.Diagnostics;

namespace Kf.CANetCore31.Core.Domain
{
    [DebuggerDisplay("{DebuggerDisplayString,nq}")]
    public sealed class Person : Entity
    {
        public static Person Empty
            => new Person();

        private Person(Id id)
            : base(id)
        { }
        private Person()
            : this(Id.Empty)
        { }

        public override string DebuggerDisplayString
            => this.CreateDebugString(x => x.Id);
    }
}
