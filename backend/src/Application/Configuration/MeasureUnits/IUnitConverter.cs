using Pibidex.Domain.MeasureUnits;

namespace Pibidex.Application.Configuration.MeasureUnits
{
    public interface IUnitConverter<TUnit>
        where TUnit : MeasureUnit
    {
        TUnit From { get; }

        TUnit To { get; }

        double Convert(double value);
    }
}