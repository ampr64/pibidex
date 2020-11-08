using Pibidex.Domain.Common;
using Pibidex.Domain.Extensions;
using Pibidex.Domain.MeasureUnits;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pibidex.Infrastructure.UnitConversion
{
    public abstract class ConversionFactorProviderBase<TUnit, TConstants> : IConversionFactorProvider<TUnit>
        where TUnit : MeasureUnit
        where TConstants : IConstants
    {
        private static readonly List<(TUnit From, TUnit To, double Factor)> _conversionChart =
            GetUnitsConversions();

        public double GetConversionFactor(TUnit from, TUnit to) => from == to
            ? 1
            : _conversionChart.SingleOrDefault(x => x.From == from && x.To == to)
                              .Factor;

        protected static string FieldName(TUnit from, TUnit to) =>
            $"{from.Name}To{to.Name}";

        protected static double FieldValue(string name) =>
            typeof(TConstants).GetFieldValue<double>(name)!;

        protected static List<(TUnit from, TUnit to, double factor)> GetUnitsConversions()
        {
            var measureUnits = MeasureUnit.GetAll().OfType<TUnit>().ToList();
            var result = new List<(TUnit from, TUnit to, double factor)>();

            foreach (var unit in measureUnits)
            {
                var unitConversions = measureUnits.Where(x => unit != x)
                    .Select(target =>
                        (from: unit,
                        to: target,
                        factor: FieldValue(FieldName(unit, target))));

                result.AddRange(unitConversions);
            }

            return result;
        }
    }
}