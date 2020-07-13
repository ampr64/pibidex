using PibidexBackend.Entities.Base;

namespace PibidexBackend.Entities
{
    public class Region : EntityBase<int>
    {
        public int GenerationId { get; set; }

        public string Description { get; set; }

        public Generation Generation { get; set; }
    }
}