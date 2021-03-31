using Pibidex.Domain.MeasureUnits;
using Pibidex.Infrastructure.UnitConversions;
using Xunit;


namespace Pibidex.UnitTests.Infrastructure.UnitConversions
{
    public class UnitConversionFactorProviderTests
    {
        [Theory]
        [MemberData(nameof(FactorProvidersTestData.LengthUnitData),
            MemberType = typeof(FactorProvidersTestData))]
        public void HasCorrectLengthConversionFactors(LengthUnit unitFrom, LengthUnit unitTo, double expected)
        {
            var provider = new LengthUnitConversionFactorProvider();

            var actualFactor = provider.GetConversionFactor(unitFrom, unitTo);

            Assert.Equal(expected, actualFactor, 3);
        }

        [Theory]
        [MemberData(nameof(FactorProvidersTestData.MassUnitData),
            MemberType = typeof(FactorProvidersTestData))]
        public void HasCorrectMassConversionFactors(MassUnit unitFrom, MassUnit unitTo, double expected)
        {
            var provider = new MassUnitConversionFactorProvider();

            var actualFactor = provider.GetConversionFactor(unitFrom, unitTo);

            Assert.Equal(expected, actualFactor, 3);
        }
    }
}