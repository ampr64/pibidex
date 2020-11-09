using Pibidex.Domain.Common;
using Pibidex.Domain.Exceptions;
using Pibidex.Domain.Rules;
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
            try
            {
                var url = new Uri(urlString);
                new UrlMustHaveHttpOrHttpsSchemeRule(url).Enforce();

                return new Url(url);
            }
            catch (Exception ex) when (ex is ArgumentNullException or UriFormatException)
            {
                throw new UrlInvalidException(urlString, ex);
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