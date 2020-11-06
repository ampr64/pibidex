using System;

namespace Pibidex.Domain.Common
{
    public interface IUnitConverter<TUnit, TValue>
        where TUnit : IUnitOfMeasure
        where TValue : IEquatable<TValue>
    {
        TUnit From { get; }

        TUnit To { get; }

        TValue Convert(TValue value);
    }
}