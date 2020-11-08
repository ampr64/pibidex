using Pibidex.Domain.Common;
using Pibidex.Domain.MeasureUnits;

namespace Pibidex.Infrastructure.UnitConversion
{
    public class MassUnitConverter : UnitConverterBase<MassUnit>
    {
        public MassUnitConverter(IConversionFactorProvider<MassUnit> factorProvider,
            MassUnit from, MassUnit to) : base(factorProvider, from, to)
        {
        }
    }
}