using Pibidex.Domain.Common;
using Pibidex.Domain.MeasureUnits;

namespace Pibidex.Infrastructure.UnitConversion
{
    public class LengthConverter : UnitConverterBase<LengthUnit>
    {
        public LengthConverter(IConversionFactorProvider<LengthUnit> factorProvider,
            LengthUnit from, LengthUnit to)
            : base(factorProvider, from, to)
        {
        }
    }
}