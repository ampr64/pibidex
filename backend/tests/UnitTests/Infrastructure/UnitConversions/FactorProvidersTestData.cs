using System.Collections.Generic;
using static Pibidex.Domain.MeasureUnits.LengthUnit;
using static Pibidex.Domain.MeasureUnits.MassUnit;

namespace Pibidex.UnitTests.Infrastructure.UnitConversions
{
    public class FactorProvidersTestData
    {
        public static readonly IEnumerable<object[]> LengthUnitData = new List<object[]>
        {
            new object[]{ Meter, Meter, 1 },
            new object[]{ Meter, Centimeter, 100 },
            new object[]{ Meter, Foot, 3.28084 },
            new object[]{ Meter, Inch, 39.3701 },
            new object[]{ Centimeter, Centimeter, 1 },
            new object[]{ Centimeter, Meter, 0.01 },
            new object[]{ Centimeter, Foot, 0.0328084 },
            new object[]{ Centimeter, Inch, 0.393701 },
            new object[]{ Foot, Foot, 1 },
            new object[]{ Foot, Meter, 0.3048 },
            new object[]{ Foot, Centimeter, 30.48 },
            new object[]{ Foot, Inch, 12 },
            new object[]{ Inch, Inch, 1 },
            new object[]{ Inch, Meter, 0.0254 },
            new object[]{ Inch, Centimeter, 2.54 },
            new object[]{ Inch, Foot, 0.0833333 }
        };

        public static readonly IEnumerable<object[]> MassUnitData = new List<object[]>
        {
            new object[]{ Kilogram, Kilogram, 1 },
            new object[]{ Kilogram, Gram, 1000 },
            new object[]{ Kilogram, Pound, 2.20462 },
            new object[]{ Kilogram, Ounce, 35.274 },
            new object[]{ Gram, Gram, 1 },
            new object[]{ Gram, Kilogram, 0.001 },
            new object[]{ Gram, Pound, 0.00220462 },
            new object[]{ Gram, Ounce, 0.035274 },
            new object[]{ Pound, Pound, 1 },
            new object[]{ Pound, Kilogram, 0.453592 },
            new object[]{ Pound, Gram, 453.592 },
            new object[]{ Pound, Ounce, 16 },
            new object[]{ Ounce, Ounce, 1 },
            new object[]{ Ounce, Kilogram, 0.0283495 },
            new object[]{ Ounce, Gram, 28.3495 },
            new object[]{ Ounce, Pound, 0.0625}
        };
    }
}
