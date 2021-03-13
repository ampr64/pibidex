using Pibidex.Domain.Common;
using static Pibidex.Domain.Constants.DamageFactorConstants;

namespace Pibidex.Domain.Enumeration
{
    public class DamageFactor : Enumeration<DamageFactor>
    {
        public static DamageFactor Ineffective = new DamageFactor(1, nameof(Ineffective), INEFFECTIVE);
        public static DamageFactor NotVeryEffective = new DamageFactor(2, "Not very effective", NOT_VERY_EFFECTIVE);
        public static DamageFactor Regular = new DamageFactor(3, nameof(Regular), REGULAR);
        public static DamageFactor SuperEffective = new DamageFactor(4, "Super effective", SUPER_EFFECTIVE);

        public double FactorValue { get; set; }

        private DamageFactor(int id, string name, double factorValue) : base(id, name) =>
            FactorValue = factorValue;
    }
}