using Ardalis.GuardClauses;
using System;

namespace Pibidex.Domain.Common
{
    public interface IId
    {
        int Value { get; }
    }

    public abstract class Id<T> : IId, IComparable<Id<T>>, IEquatable<Id<T>>, IEquatable<T>, IComparable<T>
        where T : Id<T>
    {
        public int Value { get; }

        public Id(int value) =>
            Value = Guard.Against.NegativeOrZero(value, nameof(value));

        public int CompareTo(Id<T>? other) =>
            other is null ? 1 : Value.CompareTo(other.Value);

        public bool Equals(Id<T>? other) =>
            other is not null && other.Value == Value;

        public override bool Equals(object? obj)
        {
            if (obj is null || obj.GetType() != GetType())
                return false;

            return Value == ((Id<T>)obj).Value;
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

        public bool Equals(T? other) =>
            other is not null && Value == other.Value;

        public int CompareTo(T? other) =>
            other is null ? 1 : Value.CompareTo(other.Value);

        public static bool operator ==(Id<T>? left, Id<T>? right)
        {
            if (left is null)
                return right is null;

            return left.Equals(right);
        }

        public static bool operator !=(Id<T>? left, Id<T>? right) => !(left == right);

        public static explicit operator int(Id<T> id) => id.Value;

        public static explicit operator Id<T>(int value) =>
            (Activator.CreateInstance(typeof(Id<T>), value) as Id<T>)!;
    }
}