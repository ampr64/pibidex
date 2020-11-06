using Ardalis.GuardClauses;
using Pibidex.Domain.Common;

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
            _factorProvider = factorProvider;
        }

        public double Convert(double value)
        {   
            Guard.Against.Null(value, nameof(value));
            return Factor * value;
        }
    }
}