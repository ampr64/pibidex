using Pibidex.Domain.Common;
using static Pibidex.Domain.Constants.DamageFactorConstants;

namespace Pibidex.Domain.Enumeration
{
    public class DamageFactor : Enumeration<DamageFactor, double>
    {
        public static DamageFactor One = new DamageFactor(_1, nameof(One));
        public static DamageFactor ThreeQuarters = new DamageFactor(_075, nameof(ThreeQuarters));
        public static DamageFactor Half = new DamageFactor(_05, nameof(Half));
        public static DamageFactor Quarter = new DamageFactor(_025, nameof(Quarter));
        public static DamageFactor Zero = new DamageFactor(_0, nameof(Zero));
        public static DamageFactor OneAndQuarter = new DamageFactor(_125, nameof(OneAndQuarter));
        public static DamageFactor OneAndHalf = new DamageFactor(_15, nameof(OneAndHalf));
        public static DamageFactor OneAndThreeQuarters = new DamageFactor(_175, nameof(OneAndThreeQuarters));
        public static DamageFactor Two = new DamageFactor(_2, nameof(Two));

        private DamageFactor(double id, string name) : base(id, name) { }
    }
}