using Pibidex.Domain.Exceptions;
using Pibidex.Domain.ValueObjects;
using Xunit;

namespace Pibidex.UnitTests.Domain.ValueObjects
{
    public class NameTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void CannotBeCreatedWithNullOrWhitespaceString(string name)
        {
            Assert.Throws<NameInvalidException>(() => Name.Of(name));
        }

        [Fact]
        public void ImplicitlyConvertsToStringCorrectly()
        {
            string expected = "Pikachu";

            var nameObject = Name.Of(expected);

            string actual = nameObject;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ExplicitlyConvertsToStringCorrectly()
        {
            var name = "Raichu";

            var nameObject = (Name)name;

            Assert.Equal(name, nameObject);
        }
    }
}