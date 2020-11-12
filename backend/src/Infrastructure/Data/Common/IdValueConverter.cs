using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pibidex.Domain.Common;

namespace Pibidex.Infrastructure.Data.Common
{
    public class IdValueConverter<TId> : ValueConverter<TId, int>
        where TId : Id<TId>
    {
        public IdValueConverter(ConverterMappingHints? mappingHints = null)
            : base(id => id.Value, value => (TId)value, mappingHints)
        {
        }
    }
}