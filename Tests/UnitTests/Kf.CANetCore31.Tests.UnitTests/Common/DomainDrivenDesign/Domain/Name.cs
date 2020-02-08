using Kf.CANetCore31.DomainDrivenDesign;
using System.Collections.Generic;

namespace Kf.CANetCore31.Tests.UnitTests.Common.DomainDrivenDesign.Domain
{
    public sealed class Name : ValueObject
    {
        public static Name Empty
            => new Name();

        public static Name Create(string firstName, string lastName)
            => new Name(firstName, lastName);

        private Name(string firstName, string lastName)
        {
            First = firstName;
            Last = lastName;
        }
        private Name()
            : this(null, null)
        { }

        public string First { get; }
        public string Last { get; }

        public override string DebuggerDisplayString
            => this.CreateDebugString(x => x.First, x => x.Last);

        protected override IEnumerable<object> EquatableValues
            => new[] { First, Last };
    }
}
