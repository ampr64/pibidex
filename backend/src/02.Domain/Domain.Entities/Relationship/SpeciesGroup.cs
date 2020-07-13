using Domain.Entities.Base;

namespace Domain.Entities.Relationship
{
    public class SpeciesGroup : EntityBase<int>
    {
        public int GroupId { get; set; }
        public int SpeciesId { get; set; }

        public Group Group { get; set; }
        public Species Species { get; set; }
    }
}