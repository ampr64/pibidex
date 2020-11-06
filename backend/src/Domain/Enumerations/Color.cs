using Pibidex.Domain.Common;

namespace Pibidex.Domain.Enumeration
{
    public class Color : Enumeration<Color>
    {
        public static readonly Color Red = new Color(1, nameof(Red));
        public static readonly Color Blue = new Color(2, nameof(Blue));
        public static readonly Color Yellow = new Color(3, nameof(Yellow));
        public static readonly Color Green = new Color(4, nameof(Green));
        public static readonly Color Black = new Color(5, nameof(Black));
        public static readonly Color Brown = new Color(6, nameof(Brown));
        public static readonly Color Purple = new Color(7, nameof(Purple));
        public static readonly Color Gray = new Color(8, nameof(Gray));
        public static readonly Color White = new Color(9, nameof(White));
        public static readonly Color Pink = new Color(10, nameof(Pink));

        private Color(int id, string name) : base(id, name)
        {
        }
    }
}