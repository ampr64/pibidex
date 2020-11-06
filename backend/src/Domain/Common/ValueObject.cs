using System;
using System.Collections.Generic;
using System.Linq;

namespace Pibidex.Domain.Common
{
    public abstract class ValueObject : IEquatable<ValueObject>, ICloneable
    {
        public static bool operator ==(ValueObject? left, ValueObject? right)
        {
            if (left is null)
                return right is null;

            return left.Equals(right);
        }

        public static bool operator !=(ValueObject? left, ValueObject? right) =>
            !(left! == right!);

        public bool Equals(ValueObject? other) => Equals(other as object);

        public override bool Equals(object? obj)
        {
            if (obj is null || obj.GetType() != GetType())
                return false;

            return GetEqualityComponents()
                .SequenceEqual(((ValueObject)obj).GetEqualityComponents());
        }

        protected abstract IEnumerable<object> GetEqualityComponents();

        public override int GetHashCode() =>
            GetEqualityComponents()
            .Select(c => c != null ? c.GetHashCode() : 0)
            .Aggregate((x, y) => x ^ y);

        public object Clone() => MemberwiseClone();

        public ValueObject GetCopy() => (ValueObject)MemberwiseClone();
    }
}