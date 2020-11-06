namespace Pibidex.Domain.MeasureUnits
{
    public class MassUnit : MeasureUnit
    {
        public static readonly MassUnit Gram = new MassUnit(1, nameof(Gram), "g", "Grams");
        public static readonly MassUnit Kilogram = new MassUnit(2, nameof(Kilogram), "kg", "Kilograms");
        public static readonly MassUnit Pound = new MassUnit(3, nameof(Pound), "lb", "Pounds");
        public static readonly MassUnit Ounce = new MassUnit(4, nameof(Ounce), "oz", "Ounces");

        public MassUnit(int id, string name, string abbreviation, string plural)
            : base(id, name, abbreviation, plural) { }
    }
}