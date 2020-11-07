using Pibidex.Domain.Common;

namespace Pibidex.Enumerations
{
    public class Group : Enumeration<Group, GroupId>
    {
        public static readonly Group Common = new Group((GroupId)1, nameof(Common));
        public static readonly Group Starter = new Group((GroupId)2, nameof(Starter));
        public static readonly Group Legendary = new Group((GroupId)3, nameof(Legendary));
        public static readonly Group Mythical = new Group((GroupId)4, nameof(Mythical));

        public Group(GroupId id, string name) : base(id, name)
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