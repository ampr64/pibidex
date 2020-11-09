using Pibidex.Domain.Common;
using System;

namespace Pibidex.Domain.Exceptions
{
    public class UrlInvalidSchemeException : DomainException
    {
        public UrlInvalidSchemeException(Uri url)
            : base($"Url \"{url}\" schema is not http or https.")
        {
        }
    }
}
