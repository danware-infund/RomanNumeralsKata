namespace RomanNumerals
{
    using FluentAssertions;
    using Xunit;

    public class RomanNumeralUnitTests
    {
        [Fact]
        public void RomanNumeral_ClassExists() =>
            new RomanNumeral().Should().NotBeNull();
    }
}
