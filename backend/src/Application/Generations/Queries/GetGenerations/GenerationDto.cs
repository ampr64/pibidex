using Pibidex.Application.Configuration.Mappings;
using Pibidex.Domain.Entities;

namespace Pibidex.Application.Generations.Queries.GetGenerations
{
    public class GenerationDto : IDto<Generation>
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int? RegionId { get; set; }
    }
}