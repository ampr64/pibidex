using Pibidex.Domain.Common;

namespace Pibidex.Domain.Entities
{
    public class Category : Entity
    {
        private Category()
        {
        }

        public Category(string name) : base(name) { }
    }
}