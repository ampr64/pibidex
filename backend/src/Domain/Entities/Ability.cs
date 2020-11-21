using Pibidex.Domain.Common;

namespace Pibidex.Domain.Entities
{
    public class Ability : Entity<AbilityId>
    {
        public string? Description { get; private set; }

        private Ability() { }

        public Ability(string name, string? description) : base(name) =>
            Description = description;

        public void SetDescription(string? description) => Description = description;
    }

    public class AbilityId : Id<AbilityId>
    {
        public AbilityId(int value) : base(value)
        {
        }
    }
}