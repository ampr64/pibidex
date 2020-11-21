using Pibidex.Domain.Common;
using Pibidex.Domain.Extensions;
using Pibidex.Domain.MeasureUnits;
using System;
using System.Collections.Concurrent;
using System.Linq;

namespace Pibidex.Infrastructure.UnitConversion
{
    public abstract class ConversionFactorProviderBase<TUnit, TConstants> : IConversionFactorProvider<TUnit>
        where TUnit : MeasureUnit
        where TConstants : IConstants
    {
        private static readonly ConcurrentDictionary<(TUnit from, TUnit to), double> _conversionChart = new();

        protected ConversionFactorProviderBase() => AddConvertions();

        public double GetConversionFactor(TUnit from, TUnit to)
        {
            if (from == to)
                return 1;

            if (!_conversionChart.TryGetValue((from, to), out var result))
                throw new InvalidOperationException($"No factor found for conversion from {from.Name} to {to.Name}");

            return result;
        }

        protected static void AddConvertions()
        {
            var measureUnits = MeasureUnit.GetAll().OfType<TUnit>().ToList();

            foreach (var source in measureUnits)
            {
                foreach (var target in measureUnits.Where(mu => mu != source))
                {
                    var fieldName = $"{source.Name}To{target.Name}";
                    var factorValue = typeof(TConstants).GetFieldValue<double>(fieldName);

                    _conversionChart.TryAdd((source, target), factorValue);
                }
            }
        }
    }
}