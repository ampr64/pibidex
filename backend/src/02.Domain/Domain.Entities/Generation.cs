using PibidexBackend.Entities.Base;

namespace PibidexBackend.Entities
{
    public class Generation : EntityBase<int>
    {
        public int RegionId { get; set; }

        public Region Region { get; set; }
    }
}