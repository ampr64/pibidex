using Pibidex.Domain.Common;

namespace Pibidex.Domain.Enumeration
{
    public class DamageFactor : Enumeration<DamageFactor>
    {
        public static DamageFactor Ineffective = new DamageFactor(1, nameof(Ineffective), 0);
        public static DamageFactor NotVeryEffective = new DamageFactor(2, "Not very effective", 0.5);
        public static DamageFactor Regular = new DamageFactor(3, nameof(Regular), 1);
        public static DamageFactor SuperEffective = new DamageFactor(4, "Super effective", 2);

        public double FactorValue { get; set; }

        private DamageFactor(int id, string name, double factorValue) : base(id, name) =>
            FactorValue = factorValue;
    }
}