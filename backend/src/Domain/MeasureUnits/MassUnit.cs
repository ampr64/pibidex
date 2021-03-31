namespace Pibidex.Domain.MeasureUnits
{
    public class MassUnit : MeasureUnit, IMassUnit
    {
        public static MassUnit Gram => new(nameof(Gram), "g", "grams");

        public static MassUnit Kilogram => new(nameof(Kilogram), "kg", "kilograms");

        public static MassUnit Pound => new(nameof(Pound), "lb", "pounds");

        public static MassUnit Ounce => new(nameof(Ounce), "oz", "ounces");

        private MassUnit(string name, string abbreviation, string plural)
            : base(name, abbreviation, plural) { }
    }
}