using Pibidex.Domain.MeasureUnits;

namespace Pibidex.Domain.ValueObjects
{
    public class Weight : Measurement<MassUnit>
    {
        public Weight(MassUnit unit, double value) : base(unit, value) { }
    }
}