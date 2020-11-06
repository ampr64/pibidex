using Pibidex.Domain.Common;


namespace Pibidex.Domain.Exceptions
{
    public class IdInvalidException : DomainException
    {
        public IdInvalidException(int id) : base($"{id} is not a valid Id.") { }
    }
}