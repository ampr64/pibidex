using Pibidex.Domain.Common;

namespace Pibidex.Infrastructure.UnitConversion
{
    public class LengthUnitsConversionConstants : IConstants
    {
        public const double MeterToCentimeter = 100;
        public const double MeterToFoot = 3.28084;
        public const double MeterToInch = 39.3701;
        public const double CentimeterToMeter = 0.01;
        public const double CentimeterToFoot = 0.032808;
        public const double CentimeterToInch = 0.393701;
        public const double FootToMeter = 0.3048;
        public const double FootToCentimeter = 30.48;
        public const double FootToInch = 12;
        public const double InchToMeter = 0.0254;
        public const double InchToCentimeter = 2.54;
        public const double InchToFoot = 0.0833333;
    }

    public class MassUnitsConversionConstants : IConstants
    {
        public const double KilogramToGram = 1000;
        public const double KilogramToPound = 2.20462;
        public const double KilogramToOunce = 35.274;
        public const double GramToKilogram = 0.001;
        public const double GramToPound = 0.00220462;
        public const double GramToOunce = 0.035274;
        public const double PoundToKilogram = 0.453592;
        public const double PoundToGram = 453.592;
        public const double PoundToOunce = 16;
        public const double OunceToKilogram = 0.0283495;
        public const double OunceToGram = 28.3495;
        public const double OunceToPound = 0.0625;
    }
}