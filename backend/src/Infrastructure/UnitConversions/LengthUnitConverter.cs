using Pibidex.Application.Configuration.MeasureUnits;
using Pibidex.Domain.MeasureUnits;

namespace Pibidex.Infrastructure.UnitConversions
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