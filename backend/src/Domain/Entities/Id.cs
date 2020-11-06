using Pibidex.Domain.Rules;
using System;

namespace Pibidex.Domain.Entities
{
    public abstract class Id : IComparable<Id>, IEquatable<Id>
    {
        public int Value { get; }

        public Id(int value)
        {
            new IdMustBeAPositiveIntegerNumberRule(value).Enforce();

            Value = value;
        }

        public int CompareTo(Id? other) =>
            other is null ? 1 : Value.CompareTo(other.Value);

        public bool Equals(Id? other) => Equals(other as object);

        public override bool Equals(object? obj)
        {
            if (obj is null || obj.GetType() != GetType())
                return false;

            return Value == ((Id)obj).Value;
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

        public static bool operator ==(Id? left, Id? right)
        {
            if (left is null)
                return right is null;

            return left.Equals(right);
        }

        public static bool operator !=(Id? left, Id? right) => !(left == right);

        public static explicit operator int(Id id) => id.Value;
    }
}