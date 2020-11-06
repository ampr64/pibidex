using Pibidex.Domain.Exceptions;
using Pibidex.Domain.ValueObjects;
using Xunit;

namespace Pibidex.UnitTests.Domain.ValueObjects
{
    public class UrlTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void CantBeCreatedWithNullOrEmptyString(string urlString)
        {
            Assert.Throws<UrlInvalidException>(() => Url.Of(urlString));
        }

        [Fact]
        public void CantBeCreatedWithoutScheme()
        {
            var urlString = "www.test.com";

            Assert.Throws<UrlInvalidException>(() => Url.Of(urlString));
        }

        [Theory]
        [InlineData(@"ftp://test/")]
        [InlineData(@"mailto:test@test.com/")]
        public void CantBeCreatedWithoutHttpOrHttpsScheme(string urlString)
        {
            Assert.Throws<UrlInvalidSchemeException>(() => Url.Of(urlString));
        }

        [Theory]
        [InlineData(@"http://www.test.com/")]
        [InlineData(@"https://www.test.com/")]
        public void IsCreatedCorrectlyWithHttpAndHttpsScheme(string urlString)
        {
            var url = Url.Of(urlString);

            Assert.Equal(url, urlString);
        }

        [Fact]
        public void ImplicitlyConvertsToStringCorrectly()
        {
            var initialUrlString = "https://www.google.com/";

            var url = Url.Of(initialUrlString);

            string convertedUrlString = url;

            Assert.Equal(initialUrlString, convertedUrlString);
        }

        [Fact]
        public void ExplicitlyConvertsFromStringCorrectly()
        {
            var urlString = "https://www.google.com/";

            var url = (Url)urlString;

            Assert.Equal(urlString, url);
        }
    }
}