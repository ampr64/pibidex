using Pibidex.Application.Configuration.MeasureUnits;
using Pibidex.Domain.MeasureUnits;

namespace Pibidex.Infrastructure.UnitConversions
{
    public class MassUnitConverter : UnitConverterBase<MassUnit>
    {
        public MassUnitConverter(IConversionFactorProvider<MassUnit> factorProvider,
            MassUnit from, MassUnit to) : base(factorProvider, from, to)
        {
        }
    }
}