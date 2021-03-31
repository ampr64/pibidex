using Ardalis.GuardClauses;
using Pibidex.Application.Configuration.MeasureUnits;
using Pibidex.Domain.MeasureUnits;
using System;

namespace Pibidex.Infrastructure.UnitConversions
{
    public abstract class UnitConverterBase<TUnit> : IUnitConverter<TUnit>
        where TUnit : MeasureUnit
    {
        protected readonly IConversionFactorProvider<TUnit> _factorProvider;

        public TUnit From { get; protected set; }

        public TUnit To { get; protected set; }

        public double Factor => _factorProvider.GetConversionFactor(From, To);

        protected UnitConverterBase(IConversionFactorProvider<TUnit> factorProvider,
            TUnit from, TUnit to)
        {
            From = Guard.Against.Null(from, nameof(from));
            To = Guard.Against.Null(to, nameof(to));
            _factorProvider = Guard.Against.Null(factorProvider, nameof(factorProvider));
        }

        public double Convert(double value) => Math.Round(Factor * value, 2);
    }
}