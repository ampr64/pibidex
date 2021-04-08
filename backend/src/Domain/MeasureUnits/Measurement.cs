using Ardalis.GuardClauses;
using Pibidex.Domain.Common;
using System;
using System.Collections.Generic;

namespace Pibidex.Domain.MeasureUnits
{
    public abstract class Measurement<TMeasurement, TUnit> : ValueObject
        where TMeasurement : Measurement<TMeasurement, TUnit>
        where TUnit : MeasureUnit
    {
        public double Value { get; }

        public TUnit Unit { get; }

        protected Measurement(double value, TUnit unit)
        {
            Value = Guard.Against.Negative(value, nameof(value));
            Unit = Guard.Against.Null(unit, nameof(unit));
        }

        public TMeasurement ConvertTo(TUnit unit)
        {
            Guard.Against.Null(unit, nameof(unit));

            var baseUnitValue = Value * GetConversionFactor(Unit);
            var convertedValue = Math.Round(baseUnitValue / GetConversionFactor(unit), 2);

            return (TMeasurement)Activator.CreateInstance(typeof(TMeasurement), convertedValue, unit)!;
        }

        protected abstract IReadOnlyDictionary<TUnit, double> ConversionFactorLookup { get; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
            yield return Unit;
        }

        private double GetConversionFactor(TUnit unit)
        {
            if (!ConversionFactorLookup.TryGetValue(unit, out var factor))
                throw new Exception($"No conversion factor found for {typeof(TMeasurement).FullName}.");

            return factor;
        }
    }
}