using Pibidex.Domain.Common;

namespace Pibidex.Enumerations
{
    public class SpeciesGroup : Enumeration<SpeciesGroup, GroupId>
    {
        public static readonly SpeciesGroup Common = new SpeciesGroup((GroupId)1, nameof(Common));
        public static readonly SpeciesGroup Baby = new SpeciesGroup((GroupId)2, nameof(Baby));
        public static readonly SpeciesGroup Starter = new SpeciesGroup((GroupId)3, nameof(Starter));
        public static readonly SpeciesGroup Legendary = new SpeciesGroup((GroupId)4, nameof(Legendary));
        public static readonly SpeciesGroup Mythical = new SpeciesGroup((GroupId)5, nameof(Mythical));

        public SpeciesGroup(GroupId id, string name)
            : base(id, name)
        {
        }
    }

    public class GroupId : Id<GroupId>
    {
        public GroupId(int value) : base(value)
        {
        }
    }
}