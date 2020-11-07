using Pibidex.Domain.Common;

namespace Pibidex.Domain.Entities
{
    public class Category : Entity<CategoryId>
    {
        private Category()
        {
        }

        public Category(string name) : base(name) { }
    }

    public class CategoryId : Id<CategoryId>
    {
        public CategoryId(int value) : base(value)
        {
        }
    }
}