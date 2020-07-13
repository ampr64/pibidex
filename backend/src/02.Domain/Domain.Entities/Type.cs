using PibidexBackend.Entities.Base;

namespace PibidexBackend.Entities
{
    public class Type : EntityBase<int>
    {
        public int GenerationId { get; set; }

        public Generation Generation { get; set; }
    }
}