using Pibidex.Infrastructure.UnitConversion;
using Xunit;

namespace Pibidex.UnitTests.Infrastructure.UnitConversion.Length
{
    public class LengthTestBase
    {
        protected static readonly LengthUnitConversionFactorProvider _factorProvider =
            new LengthUnitConversionFactorProvider();
    }
}