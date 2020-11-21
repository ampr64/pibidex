using Pibidex.Domain.Common;

namespace Pibidex.Domain.Entities
{
    public class Region : Entity<RegionId>
    {
        public GenerationId GenerationId { get; private set; } = null!;

        public Generation Generation { get; private set; } = null!;

        public string? Description { get; private set; }

        private Region() { }

        public Region(string name, GenerationId generationId, string description) : base(name) =>
            (GenerationId, Description) = (generationId, description);

        public void SetDescription(string? description) =>
            Description = description;
    }

    public class RegionId : Id<RegionId>
    {
        public RegionId(int value) : base(value)
        {
        }
    }
}