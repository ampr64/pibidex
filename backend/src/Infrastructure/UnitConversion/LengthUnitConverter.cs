using Pibidex.Domain.Common;
using Pibidex.Domain.MeasureUnits;

namespace Pibidex.Infrastructure.UnitConversion
{
    public class LengthUnitConverter : UnitConverterBase<LengthUnit>
    {
        public LengthUnitConverter(IConversionFactorProvider<LengthUnit> factorProvider,
            LengthUnit from, LengthUnit to)
            : base(factorProvider, from, to)
        {
        }
    }
}