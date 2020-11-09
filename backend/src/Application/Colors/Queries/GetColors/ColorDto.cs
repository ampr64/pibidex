using Pibidex.Application.Configuration.Mappings;
using Pibidex.Domain.Enumeration;

namespace Pibidex.Application.Colors.Queries.GetColors
{
    public class ColorDto : IDto<Color>
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
    }
}