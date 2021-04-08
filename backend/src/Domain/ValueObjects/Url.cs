using Ardalis.GuardClauses;
using Pibidex.Domain.Common;
using Pibidex.Domain.Exceptions;
using System;
using System.Collections.Generic;

namespace Pibidex.Domain.ValueObjects
{
    public class Url : ValueObject
    {
        public string Value { get; private set; }

        private Url(string value) => Value = value;

        private Url(Uri url) => Value = url.ToString();

        public static Url Of(string urlString)
        {
            Guard.Against.NullOrWhiteSpace(urlString, nameof(urlString));
            try
            {
                var url = new Uri(urlString);

                if (url.Scheme != Uri.UriSchemeHttp && url.Scheme != Uri.UriSchemeHttps)
                    throw new UrlInvalidSchemeException(url);

                return new Url(url);
            }
            catch (Exception ex) when (ex is ArgumentNullException or UriFormatException)
            {
                throw new UrlInvalidFormatException(urlString, ex);
            }
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value;

        public static explicit operator string(Url url) => url.Value;

        public static explicit operator Url(string urlString) => Of(urlString);
    }
}