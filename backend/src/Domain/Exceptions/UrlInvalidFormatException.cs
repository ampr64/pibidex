using Pibidex.Domain.Common;
using System;

namespace Pibidex.Domain.Exceptions
{
    public class UrlInvalidFormatException : DomainException
    {
        public UrlInvalidFormatException(string url, Exception innerException) :
            base($"Url \"{url}\" is not in a valid format.", innerException)
        {
        }
    }
}