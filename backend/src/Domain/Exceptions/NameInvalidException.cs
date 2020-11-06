using Pibidex.Domain.Common;

namespace Pibidex.Domain.Exceptions
{
    public class NameInvalidException : DomainException
    {
        public NameInvalidException(string? name)
            : base($"Name \"{name}\" is not a valid name.") { }
    }
}