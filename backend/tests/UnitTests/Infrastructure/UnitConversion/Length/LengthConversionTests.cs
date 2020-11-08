using Pibidex.Domain.MeasureUnits;
using Pibidex.Infrastructure.UnitConversion;
using Xunit;

namespace Pibidex.UnitTests.Infrastructure.UnitConversion.Length
{
    public class LengthConversionTests : LengthTestBase
    {
        [Theory]
        [InlineData(1.12, 112)]
        [InlineData(3.74, 374)]
        [InlineData(27.89, 2789)]
        public void ConvertsToCentimetersCorrectly(double input, double expected)
        {
            var converter = new LengthUnitConverter(_factorProvider, LengthUnit.Meter, LengthUnit.Centimeter);

            var actual = converter.Convert(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1.84, 6.04)]
        [InlineData(3.74, 12.27)]
        [InlineData(27.89, 91.50)]
        public void ConvertsMetersToFeetCorrectly(double input, double expected)
        {
            var converter = new LengthUnitConverter(_factorProvider, LengthUnit.Meter, LengthUnit.Foot);

            var actual = converter.Convert(input);

            Assert.Equal(expected, actual, 2);
        }

        [Theory]
        [InlineData(1.12, 112)]
        [InlineData(3.74, 374)]
        [InlineData(27.89, 2789)]
        public void ConvertsMetersToInchesCorrectly(double input, double expected)
        {
            var converter = new LengthUnitConverter(_factorProvider, LengthUnit.Meter, LengthUnit.Centimeter);

            var actual = converter.Convert(input);

            Assert.Equal(expected, actual);
        }
    }
}