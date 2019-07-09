namespace RomanNumerals
{
    using FluentAssertions;
    using Xunit;

    public class RomanNumeralUnitTests
    {
        [Fact]
        public void GivenNull_ShouldReturnZero()
        {
            RomanNumeral.NumeralToInteger(null)
                .Should().Be(0);
        }

        [Fact]
        public void GivenEmptyString_ShouldReturnZero()
        {
            RomanNumeral.NumeralToInteger(string.Empty)
                .Should().Be(0);
        }

        [Fact]
        public void GivenI_ShouldReturn1()
        {
            RomanNumeral.NumeralToInteger("I")
                .Should().Be(1);
        }

        [Fact]
        public void GivenV_ShouldReturn5()
        {
            RomanNumeral.NumeralToInteger("V")
                .Should().Be(5);
        }

        [Fact]
        public void GivenX_ShouldReturn10()
        {
            RomanNumeral.NumeralToInteger("X")
              .Should().Be(10);
        }

        [Fact]
        public void GivenL_ShouldReturn50()
        {
            RomanNumeral.NumeralToInteger("L")
              .Should().Be(50);
        }

        [Fact]
        public void GivenC_ShouldReturn100()
        {
            RomanNumeral.NumeralToInteger("C")
              .Should().Be(100);
        }

        [Fact]
        public void GivenD_ShouldReturn500()
        {
            RomanNumeral.NumeralToInteger("D")
              .Should().Be(500);
        }

        [Fact]
        public void GivenM_ShouldReturn1000()
        {
            RomanNumeral.NumeralToInteger("M")
              .Should().Be(1000);
        }

        [Fact]
        public void GivenRepeatedNumerals_ShouldReturnAddedTotal()
        {
            RomanNumeral.NumeralToInteger("III")
              .Should().Be(3);

            RomanNumeral.NumeralToInteger("XX")
              .Should().Be(20);
        }
    }
}
