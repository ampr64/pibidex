using Pibidex.Domain.Common;
using Pibidex.Domain.Enumeration;
using System;
using System.Collections.Generic;

namespace Pibidex.Domain.ValueObjects
{
    public class Damage : ValueObject, IComparable<Damage>, IComparable<double>
    {
        public double Factor { get; private set; }

        public Damage(DamageFactor factor) => Factor = factor;

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Factor;
        }

        public int CompareTo(double value) => Factor.CompareTo(value);

        public int CompareTo(Damage? other) =>
            other is null ? 1 : Factor.CompareTo(other.Factor);
    }
}