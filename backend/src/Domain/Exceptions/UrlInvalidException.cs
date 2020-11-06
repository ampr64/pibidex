using Pibidex.Domain.Common;
using System;

namespace Pibidex.Domain.Exceptions
{
    public class UrlInvalidException : DomainException
    {
        public UrlInvalidException(string url, Exception innerException) :
            base($"Url \"{url}\" is invalid.", innerException)
        {
        }
    }
}