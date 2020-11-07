using Pibidex.Domain.Rules;
using System;

namespace Pibidex.Domain.Common
{
    public abstract class Id<TId> : IComparable<Id<TId>>, IEquatable<Id<TId>>, IEquatable<TId>, IComparable<TId>
        where TId : Id<TId>
    {
        public int Value { get; }

        public Id(int value)
        {
            new IdMustBeAPositiveIntegerNumberRule(value).Enforce();

            Value = value;
        }

        public int CompareTo(Id<TId>? other) =>
            other is null ? 1 : Value.CompareTo(other.Value);

        public bool Equals(Id<TId>? other) =>
            other is not null && other.Value == Value;

        public override bool Equals(object? obj)
        {
            if (obj is null || obj.GetType() != GetType())
                return false;

            return Value == ((Id<TId>)obj).Value;
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

        public bool Equals(TId? other) =>
            other is not null && Value == other.Value;

        public int CompareTo(TId? other) =>
            other is null ? 1 : Value.CompareTo(other.Value);

        public static bool operator ==(Id<TId>? left, Id<TId>? right)
        {
            if (left is null)
                return right is null;

            return left.Equals(right);
        }

        public static bool operator !=(Id<TId>? left, Id<TId>? right) => !(left == right);

        public static explicit operator int(Id<TId> id) => id.Value;

        public static explicit operator Id<TId>(int value) =>
            (Activator.CreateInstance(typeof(Id<TId>), value) as Id<TId>)!;
    }
}