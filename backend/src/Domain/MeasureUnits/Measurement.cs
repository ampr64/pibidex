using Ardalis.GuardClauses;
using Pibidex.Domain.Common;
using System.Collections.Generic;

namespace Pibidex.Domain.MeasureUnits
{
    public abstract class Measurement<TUnit> : ValueObject
        where TUnit : IUnitOfMeasure
    {
        public double Value { get; protected set; }

        public TUnit Unit { get; protected set; }

        protected Measurement(TUnit unit, double value)
        {
            Unit = Guard.Against.Null(unit, nameof(unit));
            Value = Guard.Against.Negative(value, nameof(value));
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
            yield return Unit;
        }
    }
}