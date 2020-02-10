using Kf.CANetCore31.DomainDrivenDesign;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Kf.CANetCore31.Core.Domain.People
{
    /// <summary>
    /// Defines a name of a person.
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplayString,nq}")]
    public sealed class Name : ValueObject
    {
        public static Name Empty
            => new Name(null, null);

        public static Name Create(string firstName, string lastName)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(firstName))
                    throw new ArgumentNullException(
                        paramName: nameof(firstName),
                        message: $"Parameter {nameof(firstName)} can not be null, empty or whitespace."
                    );

                if (String.IsNullOrWhiteSpace(firstName))
                    throw new ArgumentNullException(
                        paramName: nameof(firstName),
                        message: $"Parameter {nameof(lastName)} can not be null, empty or whitespace."
                    );

                return new Name(firstName.Trim(), lastName.Trim());
            }
            catch (Exception exception)
            {
                throw new InvalidNameException(
                    message: $"Name could not be constructed, see innerException for more details.",
                    innerException: exception
                );
            }
        }

        private Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        private Name() { }

        public string FirstName { get; }
        public string LastName { get; }

        public override string DebuggerDisplayString
            => this.CreateDebugString(x => x.FirstName, x => x.LastName);

        protected override IEnumerable<object> EquatableValues
            => new[] { FirstName, LastName };
    }
}
