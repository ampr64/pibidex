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
            Assert.Throws<UrlInvalidFormatException>(() => Url.Of(urlString));
        }

        [Fact]
        public void CantBeCreatedWithoutScheme()
        {
            var urlString = "www.test.com";

            Assert.Throws<UrlInvalidFormatException>(() => Url.Of(urlString));
        }

        [Theory]
        [InlineData(@"ftp://test/")]
        [InlineData(@"mailto:test@test.com/")]
        public void CantBeCreatedWithoutHttpOrHttpsScheme(string urlString)
        {
            Assert.Throws<UrlInvalidSchemeException>(() => Url.Of(urlString));
        }

        [Fact]
        public void AddsTrailingSlashOnCreation()
        {
            var input = "https://www.google.com";

            var expected = input + '/';

            var url = Url.Of(input);

            Assert.Equal(expected, (string)url);
        }

        [Theory]
        [InlineData(@"http://www.test.com/")]
        [InlineData(@"https://www.test.com/")]
        public void IsCreatedCorrectlyWithHttpAndHttpsScheme(string urlString)
        {
            var url = Url.Of(urlString);

            Assert.Equal(url.Value, urlString);
        }

        [Fact]
        public void ExplicitlyConvertsToStringCorrectly()
        {
            var initialUrlString = "https://www.google.com";

            var expected = initialUrlString + '/';

            var url = Url.Of(initialUrlString);

            var convertedUrlString = (string)url;

            Assert.Equal(expected, convertedUrlString);
        }

        [Fact]
        public void ExplicitlyConvertsFromStringCorrectly()
        {
            var urlStringToConvert = "https://www.google.com";

            var expected = urlStringToConvert + '/';

            var convertedUrl = (Url)urlStringToConvert;

            Assert.Equal(expected, convertedUrl.Value);
        }
    }
}