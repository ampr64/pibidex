using Pibidex.Domain.Common;
using Pibidex.Domain.Exceptions;
using System;

namespace Pibidex.Domain.Rules
{
    public class UrlMustBeValidWithHttpOrHttpsSchemeRule : IBusinessRule
    {
        private readonly string _urlString;

        private Uri? _url;

        public bool Condition =>
            _url?.Scheme == Uri.UriSchemeHttp || _url?.Scheme == Uri.UriSchemeHttps;

        public UrlMustBeValidWithHttpOrHttpsSchemeRule(string urlString) => _urlString = urlString;

        public void Enforce()
        {
            try
            {
                _url = new Uri(_urlString);

                if (!Condition)
                    throw new UrlInvalidSchemeException(_urlString);
            }
            catch (Exception ex) when (ex is ArgumentNullException or UriFormatException)
            {
                throw new UrlInvalidException(_urlString, ex);
            }
        }
    }
}