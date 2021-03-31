using Pibidex.Domain.Common;

namespace Pibidex.Domain.Enums
{
    public class Gender : Enumeration<Gender>
    {
        public static readonly Gender Female = new Gender(1, nameof(Female));
        public static readonly Gender Male = new Gender(2, nameof(Male));
        public static readonly Gender Undefined = new Gender(3, nameof(Undefined));

        public Gender(int id, string name) : base(id, name)
        {
        }
    }
}