namespace Pibidex.Domain.MeasureUnits
{
    public interface IUnitOfMeasure
    {
        string Name { get; }

        string Abbreviation { get; }

        string Plural { get; }
    }
}