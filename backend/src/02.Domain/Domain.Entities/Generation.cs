using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Generation : EntityBase<int>
    {
        public int RegionId { get; set; }

        public Region Region { get; set; }
    }
}