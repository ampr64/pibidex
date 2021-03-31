using Ardalis.GuardClauses;
using Pibidex.Domain.Common;
using System.Collections.Generic;

namespace Pibidex.Domain.MeasureUnits
{
    public abstract class MeasureUnit : ValueObject, IUnitOfMeasure
    {
        public string Name { get; }

        public string Abbreviation { get; }

        public string Plural { get; }

        public double ToBaseUnit { get; }

        public double FromBaseUnit { get; }

        protected MeasureUnit(string name, string abbreviation, string plural, double toBaseUnit, double fromBaseUnit)
        {
            Name = Guard.Against.NullOrEmpty(name, nameof(name));
            Abbreviation = Guard.Against.NullOrEmpty(abbreviation, nameof(abbreviation));
            Plural = Guard.Against.NullOrEmpty(plural, nameof(plural));
            ToBaseUnit = toBaseUnit;
            FromBaseUnit = fromBaseUnit;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return Abbreviation;
            yield return Plural;
        }
    }
}