using Pibidex.Application.Configuration.MeasureUnits;
using Pibidex.Domain.Extensions;
using Pibidex.Domain.MeasureUnits;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;

namespace Pibidex.Infrastructure.UnitConversions
{
    public abstract class ConversionFactorProviderBase<TUnit> : IConversionFactorProvider<TUnit>
        where TUnit : MeasureUnit
    {
        private static readonly ConcurrentDictionary<(TUnit from, TUnit to), double> _conversionsLookup = new();

        protected ConversionFactorProviderBase()
        {
            LoadConversionsLookup(typeof(LengthUnitConstants));
            LoadConversionsLookup(typeof(MassUnitConstants));
        }

        public double GetConversionFactor(TUnit from, TUnit to)
        {
            if (from.Equals(to))
                return 1;

            if (!_conversionsLookup.TryGetValue((from, to), out var factor))
                throw new InvalidOperationException($"No factor found for conversion from {from.Name} to {to.Name}");

            return factor;
        }

        private static void LoadConversionsLookup(Type constantsType)
        {
            if (!_conversionsLookup.Any())
            {
                constantsType.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly).ToList()
                    .ForEach(constant =>
                    {
                        var unitsNames = constant.Name.Split("To", StringSplitOptions.RemoveEmptyEntries);

                        if (unitsNames.Length == 2)
                        {
                            var source = typeof(TUnit).GetPropertyValue<TUnit>(unitsNames[0], null);
                            var target = typeof(TUnit).GetPropertyValue<TUnit>(unitsNames[1], null);
                            var factor = (double)constant.GetValue(null)!;

                            _conversionsLookup.TryAdd((source, target), factor);
                        }
                    });
            }
        }
    }
}