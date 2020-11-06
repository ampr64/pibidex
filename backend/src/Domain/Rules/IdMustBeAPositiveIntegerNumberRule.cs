using Pibidex.Domain.Common;
using Pibidex.Domain.Exceptions;

namespace Pibidex.Domain.Rules
{
    public class IdMustBeAPositiveIntegerNumberRule : IBusinessRule
    {
        private readonly int _id;

        public bool Condition => _id > 0;

        public IdMustBeAPositiveIntegerNumberRule(int id) => _id = id;

        public void Enforce()
        {
            if (!Condition)
                throw new IdInvalidException(_id);
        }
    }
}