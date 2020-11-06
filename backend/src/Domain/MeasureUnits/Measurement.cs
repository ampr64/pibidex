using Ardalis.GuardClauses;
using Pibidex.Domain.MeasureUnits;
using System.Collections.Generic;

namespace Pibidex.Domain.Common
{
    public abstract class Measurement<TUnit> : ValueObject
        where TUnit : MeasureUnit
    {
        public TUnit Unit { get; protected set; }

        public double Value { get; protected set; }

        protected Measurement(TUnit unit, double value)
        {
            Unit = Guard.Against.Null(unit, nameof(unit));
            Value = Guard.Against.NegativeOrZero(value, nameof(value));
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
            yield return Unit;
        }
    }
}