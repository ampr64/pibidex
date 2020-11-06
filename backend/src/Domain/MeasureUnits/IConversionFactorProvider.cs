namespace Pibidex.Domain.Common
{
    public interface IConversionFactorProvider<TUnit>
        where TUnit : IUnitOfMeasure
    {
        double GetConversionFactor(TUnit from, TUnit to);
    }
}