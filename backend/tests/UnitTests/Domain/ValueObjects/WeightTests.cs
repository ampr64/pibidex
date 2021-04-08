using Pibidex.Domain.MeasureUnits;
using Pibidex.Domain.ValueObjects;
using Xunit;

namespace Pibidex.UnitTests.Domain.ValueObjects
{
    public class WeightTests
    {
        [Fact]
        public void ConvertsWell()
        {
            var weight1 = new Weight(10, MassUnit.Kilogram);
            var weight2 = weight1.ConvertTo(MassUnit.Ounce);

            Assert.Equal(new Weight(352.74, MassUnit.Ounce), weight2);
        }
    }
}