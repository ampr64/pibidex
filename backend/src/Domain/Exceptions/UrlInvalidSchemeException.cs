using Pibidex.Domain.Common;

namespace Pibidex.Domain.Exceptions
{
    public class UrlInvalidSchemeException : DomainException
    {
        public UrlInvalidSchemeException(string url)
            : base($"Url \"{url}\" schema is not http or https.")
        {
        }
    }
}
