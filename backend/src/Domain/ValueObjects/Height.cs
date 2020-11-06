using Pibidex.Domain.Common;
using Pibidex.Domain.MeasureUnits;

namespace Pibidex.Domain.ValueObjects
{
    public class Height : Measurement<LengthUnit>
    {
        public Height(LengthUnit unit, double value) : base(unit, value) { }
    }
}