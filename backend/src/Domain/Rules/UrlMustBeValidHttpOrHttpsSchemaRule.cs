using Pibidex.Domain.Common;
using Pibidex.Domain.Exceptions;
using System;

namespace Pibidex.Domain.Rules
{
    public class UrlMustHaveHttpOrHttpsSchemeRule : IBusinessRule
    {
        private readonly Uri _url;

        public bool Condition =>
            _url.Scheme == Uri.UriSchemeHttp || _url.Scheme == Uri.UriSchemeHttps;

        public UrlMustHaveHttpOrHttpsSchemeRule(Uri url) =>
            _url = url ?? throw new ArgumentNullException(nameof(url));

        public void Enforce()
        {
            if (!Condition)
                throw new UrlInvalidSchemeException(_url);
        }
    }
}