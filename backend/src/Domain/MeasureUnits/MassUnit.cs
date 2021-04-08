namespace Pibidex.Domain.MeasureUnits
{
    public sealed class MassUnit : MeasureUnit
    {
        public static MassUnit Gram => new(1, nameof(Gram), "g", "Grams");

        public static MassUnit Kilogram => new(2, nameof(Kilogram), "kg", "Kilograms");

        public static MassUnit Pound => new(3, nameof(Pound), "lb", "Pounds");

        public static MassUnit Ounce => new(4, nameof(Ounce), "oz", "Ounces");

        private MassUnit(int id, string name, string abbreviation, string plural)
            : base(id, name, abbreviation, plural) { }
    }
}