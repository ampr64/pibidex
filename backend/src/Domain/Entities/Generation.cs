using Pibidex.Domain.Common;

namespace Pibidex.Domain.Entities
{
    public class Generation : Entity
    {
        public int? RegionId { get; private set; }

        public Region? Region { get; private set; }

        private Generation() { }

        public Generation(int regionId, string name) : base(name) =>
            RegionId = regionId;
    }
}