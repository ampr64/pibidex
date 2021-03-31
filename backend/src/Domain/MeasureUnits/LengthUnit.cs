namespace Pibidex.Domain.MeasureUnits
{
    public sealed class LengthUnit : MeasureUnit, ILengthUnit
    {
        public static LengthUnit Centimeter => new(nameof(Centimeter), "centimeters", "cm", 0.01, 100);

        public static LengthUnit Meter => new(nameof(Meter), "meters", "m", 1, 1);

        public static LengthUnit Foot => new(nameof(Foot), "feet", "ft", 0.3048, 3.28084);

        public static LengthUnit Inch => new(nameof(Inch), "inches", "in", 0.0254, 39.3701);

        private LengthUnit(string name, string abbreviation, string plural, double toBaseUnit, double fromBaseUnit)
            : base(name, abbreviation, plural, toBaseUnit, fromBaseUnit) { }
    }
}