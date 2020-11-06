using Pibidex.Domain.Common;
using Pibidex.Domain.Rules;
using System.Collections.Generic;

namespace Pibidex.Domain.ValueObjects
{
    public class Url : ValueObject
    {
        public string Value { get; private set; }

        private Url(string value) => Value = value;

        public static Url Of(string urlString)
        {
            new UrlMustBeValidWithHttpOrHttpsSchemeRule(urlString).Enforce();

            return new Url(urlString);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value;

        public static implicit operator string(Url url) => url.Value;

        public static explicit operator Url(string urlString) => Of(urlString);
    }
}