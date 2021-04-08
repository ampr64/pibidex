using Pibidex.Domain.MeasureUnits;
using System.Collections.Generic;

namespace Pibidex.Domain.ValueObjects
{
    public class Height : Measurement<Height, LengthUnit>
    {
        public Height(double value, LengthUnit unit) : base(value, unit)
        {
        }

        protected override IReadOnlyDictionary<LengthUnit, double> ConversionFactorLookup =>
            new Dictionary<LengthUnit, double>
            {
                { LengthUnit.Meter, 1 },
                { LengthUnit.Centimeter, 0.01 },
                { LengthUnit.Foot, 0.3048},
                { LengthUnit.Inch, 0.0254},
            };
    }
}