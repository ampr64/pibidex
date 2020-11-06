using Pibidex.Domain.Common;
using Pibidex.Domain.Exceptions;

namespace Pibidex.Domain.Rules
{
    public class NameCannotBeNullOrWhiteSpaceRule : IBusinessRule
    {
        private string? _name;

        public bool Condition => !string.IsNullOrWhiteSpace(_name);

        public NameCannotBeNullOrWhiteSpaceRule(string? name) => _name = name;

        public void Enforce()
        {
            if (!Condition)
                throw new NameInvalidException(_name);
        }
    }
}