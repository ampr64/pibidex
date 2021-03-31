using Pibidex.Domain.MeasureUnits;

namespace Pibidex.Application.Configuration.MeasureUnits
{
    public interface IConversionFactorProvider<TUnit>
        where TUnit : MeasureUnit
    {
        double GetConversionFactor(TUnit from, TUnit to);
    }
}