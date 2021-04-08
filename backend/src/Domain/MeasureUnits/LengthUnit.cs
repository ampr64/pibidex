namespace Pibidex.Domain.MeasureUnits
{
    public sealed class LengthUnit : MeasureUnit
    {
        public static LengthUnit Centimeter => new(1, nameof(Centimeter), "centimeters", "cm");

        public static LengthUnit Meter => new(2, nameof(Meter), "meters", "m");

        public static LengthUnit Foot => new(3, nameof(Foot), "feet", "ft");

        public static LengthUnit Inch => new(4, nameof(Inch), "inches", "in");

        private LengthUnit(int id, string name, string abbreviation, string plural)
            : base(id, name, abbreviation, plural) { }
    }
}