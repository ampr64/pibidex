using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pibidex.Domain.Common;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Pibidex.Infrastructure.Data.Common
{
    public class IdValueConverterSelector : ValueConverterSelector
    {
        private readonly ConcurrentDictionary<(Type ModelClrType, Type ProviderClrType), ValueConverterInfo> _converters = new();

        public IdValueConverterSelector(ValueConverterSelectorDependencies dependencies)
            : base(dependencies)
        {
        }

        public override IEnumerable<ValueConverterInfo> Select(Type modelClrType, Type? providerClrType = null)
        {
            var baseConverters = base.Select(modelClrType, providerClrType);

            foreach (var converter in baseConverters)
                yield return converter;

            var underlyingModelType = UnwrapNullableType(modelClrType);
            var underlyingProviderType = UnwrapNullableType(providerClrType);

            if (underlyingModelType is null || underlyingModelType == typeof(int))
            {
                var isTypedId = typeof(Id<>).GetGenericTypeDefinition() == underlyingModelType;
                if (isTypedId)
                {
                    var converterType = typeof(Id<>).MakeGenericType(underlyingModelType!);

                    yield return _converters.GetOrAdd((underlyingModelType!, typeof(int)), _ =>
                    {
                        return new ValueConverterInfo(
                            modelClrType: modelClrType,
                            providerClrType: typeof(int),
                            factory: valueConverterInfo => (ValueConverter)Activator.CreateInstance(converterType, valueConverterInfo.MappingHints)!);
                    });
                }
            }
        }

        private static Type? UnwrapNullableType(Type? type)
        {
            if (type is null)
                return null;

            return Nullable.GetUnderlyingType(type) ?? type;
        }
    }
}