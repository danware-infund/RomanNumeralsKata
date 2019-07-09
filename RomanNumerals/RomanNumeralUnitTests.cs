namespace RomanNumerals
{
    using FluentAssertions;
    using Xunit;

    public class RomanNumeralUnitTests
    {
        [Fact]
        public void GivenNull_ShouldReturnZero()
        {
            var output = RomanNumeral.NumeralToInteger(null);
            output.Should().Be(0);
        }

        [Fact]
        public void GivenEmptyString_ShouldReturnZero()
        {
            var output = RomanNumeral.NumeralToInteger(string.Empty);
            output.Should().Be(0);
        }

        [Fact]
        public void GivenI_ShouldReturn1()
        {
            var output = RomanNumeral.NumeralToInteger("I");
            output.Should().Be(1);
        }
    }
}
