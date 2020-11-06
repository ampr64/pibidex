using Pibidex.Domain.Common;

namespace Pibidex.Domain.MeasureUnits
{
    public abstract class MeasureUnit : Enumeration<MeasureUnit>, IUnitOfMeasure
    {
        public string Abbreviation { get; private set; }

        public string Plural { get; private set; }

        protected MeasureUnit(int id, string name, string abbreviation, string plural) : base(id, name) =>
            (Abbreviation, Plural) = (abbreviation, plural);
    }
}