using Pibidex.Domain.MeasureUnits;
using System.Collections.Generic;

namespace Pibidex.Domain.ValueObjects
{
    public class Weight : Measurement<Weight, MassUnit>
    {
        public Weight(double value, MassUnit unit) : base(value, unit)
        {
        }

        protected override IReadOnlyDictionary<MassUnit, double> ConversionFactorLookup =>
            new Dictionary<MassUnit, double>
            {
                { MassUnit.Gram, 1 },
                { MassUnit.Kilogram, 1000 },
                { MassUnit.Pound, 453.592 },
                { MassUnit.Ounce, 28.3495 },
            };
    }
}