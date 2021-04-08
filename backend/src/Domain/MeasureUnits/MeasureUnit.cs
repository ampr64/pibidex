using Ardalis.GuardClauses;
using Pibidex.Domain.Common;

namespace Pibidex.Domain.MeasureUnits
{
    public abstract class MeasureUnit : Enumeration<MeasureUnit>
    {
        public string Abbreviation { get; }

        public string Plural { get; }

        protected MeasureUnit(int id, string name, string abbreviation, string plural) : base(id, name)
        {
            Abbreviation = Guard.Against.NullOrEmpty(abbreviation, nameof(abbreviation));
            Plural = Guard.Against.NullOrEmpty(plural, nameof(plural));
        }
    }
}