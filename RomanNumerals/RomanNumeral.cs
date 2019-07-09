namespace RomanNumerals
{
    public class RomanNumeral
    {
        public static int NumeralToInteger(string value)
        {
            var numericValue = 0;

            if (!string.IsNullOrEmpty(value))
            {
                for (int i = 0; i < value.Length; i++)
                    numericValue += NumeralModifier(value, i);
            }

            return numericValue;
        }

        private static int NumeralModifier(string sourceNumeral, int currentIndex)
        {
            var currentVal = RomanCharacterValue(sourceNumeral[currentIndex]);
            var nextVal = (currentIndex < sourceNumeral.Length - 1) ? RomanCharacterValue(sourceNumeral[currentIndex + 1]) : 0;

            return currentVal < nextVal ? -currentVal : currentVal;
        }

        private static int RomanCharacterValue(char value)
        {
            switch (value)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
        }
    }
}
