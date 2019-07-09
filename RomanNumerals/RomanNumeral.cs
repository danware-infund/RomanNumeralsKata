namespace RomanNumerals
{
    public class RomanNumeral
    {
        public static int NumeralToInteger(string numeral)
        {
            switch (numeral)
            {
                case "I": return 1;
                case "V": return 5;
                default: return 0;
            }
        }
    }
}
