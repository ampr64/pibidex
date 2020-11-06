using Pibidex.Domain.Common;

namespace Pibidex.Domain.Constants
{
    public struct LengthUnitsConversionConstants : IConstants
    {
        public static readonly double MeterToCentimeter = 100;
        public static readonly double MeterToFoot = 3.2808;
        public static readonly double MeterToInch = 39.3701;
        public static readonly double CentimeterToMeter = 0.01;
        public static readonly double CentimeterToFoot = 0.032808;
        public static readonly double CentimeterToInch = 0.393701;
        public static readonly double FootToMeter = 0.3048;
        public static readonly double FootToCentimeter = 30.48;
        public static readonly double FootToInch = 12;
        public static readonly double InchToMeter = 0.0254;
        public static readonly double InchToCentimeter = 2.54;
        public static readonly double InchToFoot = 0.0833333;
    }

    public struct WeightConversionConstants : IConstants
    {
        public static readonly double KilogramToGram = 100;
        public static readonly double KilogramToPound = 2.20462;
        public static readonly double KilogramToOunce = 35.274;
        public static readonly double GramToKilogram = 0.01;
        public static readonly double GramToPound = 0.0220462;
        public static readonly double GramToOunce = 0.035274;
        public static readonly double PoundToKilogram = 0.453592;
        public static readonly double PoundToGram = 453.592;
        public static readonly double PoundToOunce = 16;
        public static readonly double OunceToKilogram = 0.0283495;
        public static readonly double OunceToGram = 28.3495;
        public static readonly double OunceToPound = 0.0625;
    }
}