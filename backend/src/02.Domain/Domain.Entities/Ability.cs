using PibidexBackend.Entities.Base;

namespace PibidexBackend.Entities
{
    public class Ability : EntityBase<int>
    {
        public string Description { get; set; }
    }
}