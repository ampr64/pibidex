using Ardalis.GuardClauses;
using Pibidex.Domain.Common;
using System;

namespace Pibidex.Infrastructure.UnitConversion
{
    public abstract class UnitConverterBase<TUnit> : IUnitConverter<TUnit, double>
        where TUnit : IUnitOfMeasure

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