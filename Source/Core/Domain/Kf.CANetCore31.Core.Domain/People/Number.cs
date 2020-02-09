using Kf.CANetCore31.DomainDrivenDesign;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Kf.CANetCore31.Core.Domain.People
{
    /// <summary>
    /// Defines a number of a person in KdG.
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplayString,nq}")]
    public sealed class Number : ValueObject
    {
        public static Number Empty
            => new Number();

        public static Number For(Person person)
            => Create(person.Id);
        public static Number Create(long number)
        {
            try
            {
                if (number < 0)
                    throw new ArgumentOutOfRangeException(
                        $"Parameter {nameof(number)} should be lower than 0.",
                        nameof(number)
                    );

                if (number.ToString().Length > 7)
                    throw new ArgumentOutOfRangeException(
                        $"Parameter {nameof(number)} should be higher than 7 digits.",
                        nameof(number)
                    );

                return new Number(number);
            }
            catch (Exception exception)
            {
                throw new InvalidNumberException(
                    message: $"Number could not be constructed, see innerException for more details.",
                    innerException: exception
                );
            }
        }

        private Number(long id)
        {
            _id = (int)id;
            _checkNumber = CalculateCheckNumber(_id);
            IdentificationNumber = $"{GenerateZeroesForIdentificationNumber()}{_id}";
            CheckNumber = $"{GenerateZeroesForCheckNumber()}{_checkNumber}";
        }
        private Number()
            : this(0)
        { }

        private readonly int _id;
        private readonly int _checkNumber;
        private readonly int _identificationNumberLength = 7;
        private readonly int _checkNumberLength = 2;
        private readonly char _seperator = '-';

        public string Value
            => $"{IdentificationNumber}{_seperator}{CheckNumber}";
        public string IdentificationNumber { get; }
        public string CheckNumber { get; }

        public override string DebuggerDisplayString
            => this.CreateDebugString(x => x._id, x => x.Value);
        public override string ToString()
            => Value;
        protected override IEnumerable<object> EquatableValues
            => new object[] { _id };

        private string GenerateZeroes(int amount)
            => new string('0', amount);
        private string GenerateZeroesForIdentificationNumber()
            => GenerateZeroes(CalulcateLeadingZeroesAmountForIdentificationNumber());
        private string GenerateZeroesForCheckNumber()
            => GenerateZeroes(CalculateLeadingZeroesAmountForCheckNumber());
        private int CalculateLeadingZeroesAmount(int number, int totalAmount)
        {
            var length = number.ToString().Length;
            if (length >= totalAmount) return 0;
            return totalAmount - length;
        }
        private int CalulcateLeadingZeroesAmountForIdentificationNumber()
            => CalculateLeadingZeroesAmount(_id, _identificationNumberLength);
        private int CalculateLeadingZeroesAmountForCheckNumber()
            => CalculateLeadingZeroesAmount(_checkNumber, _checkNumberLength);
        private int CalculateCheckNumber(int id)
            => id % 97;
    }
}
