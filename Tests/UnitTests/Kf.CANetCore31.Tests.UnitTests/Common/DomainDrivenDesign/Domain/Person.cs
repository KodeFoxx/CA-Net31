using Kf.CANetCore31.DomainDrivenDesign;

namespace Kf.CANetCore31.Tests.UnitTests.Common.DomainDrivenDesign.Domain
{
    public sealed class Person : Entity
    {
        public static Person Empty
            => new Person();

        public static Person Create(Id id, Name name)
            => new Person(id, name);
        public static Person Create(Id id, string firstName, string lastName)
            => new Person(id, Name.Create(firstName, lastName));

        private Person(Id id, Name name)
            : base(id)
            => Name = name;
        private Person()
            : this(0, Name.Empty)
        { }

        public Name Name { get; }
    }
}
