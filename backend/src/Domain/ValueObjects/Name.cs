using Pibidex.Domain.Common;
using Pibidex.Domain.Rules;
using System.Collections.Generic;

namespace Pibidex.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public string Value { get; private set; }

        private Name(string value) => Value = value;

        public static Name Of(string value)
        {
            new NameCannotBeNullOrWhiteSpaceRule(value).Enforce();

            return new Name(value);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value;

        public static implicit operator string(Name name) => name.Value;

        public static explicit operator Name(string value) => new Name(value);
    }
}