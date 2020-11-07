using Ardalis.GuardClauses;
using Pibidex.Domain.Common;

namespace Pibidex.Domain.Entities
{
    public class Generation : Entity<GenerationId>
    {
        public RegionId? RegionId { get; private set; }

        public Region? Region { get; private set; }

        private Generation() { }

        public Generation(string name, RegionId? regionId = null) : base(name) =>
            RegionId = regionId;

        public void SetRegion(RegionId regionId) =>
            RegionId = Guard.Against.Null(regionId, nameof(regionId));
    }

    public class GenerationId : Id<GenerationId>
    {
        public GenerationId(int value) : base(value)
        {
        }
    }
}