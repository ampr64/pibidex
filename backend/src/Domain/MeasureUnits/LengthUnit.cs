namespace Pibidex.Domain.MeasureUnits
{
    public class LengthUnit : MeasureUnit
    {
        public static readonly LengthUnit Centimeter = new LengthUnit(1, nameof(Centimeter), "Centimeters", "cm");
        public static readonly LengthUnit Meter = new LengthUnit(2, nameof(Meter), "Meters", "m");
        public static readonly LengthUnit Foot = new LengthUnit(3, nameof(Foot), "Feet", "ft");
        public static readonly LengthUnit Inch = new LengthUnit(4, nameof(Inch), "Inches", "in");

        private LengthUnit(int id, string name, string abbreviation, string plural)
            : base(id, name, abbreviation, plural) { }
    }
}