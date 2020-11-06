using Pibidex.Domain.Common;

namespace Pibidex.Enumerations
{
    public class Group : Enumeration<Group>
    {
        public static readonly Group Common = new Group(1, nameof(Common));
        public static readonly Group Starter = new Group(2, nameof(Starter));
        public static readonly Group Legendary = new Group(3, nameof(Legendary));
        public static readonly Group Mythical = new Group(4, nameof(Mythical));

        private Group(int id, string name) : base(id, name) { }
    }
}