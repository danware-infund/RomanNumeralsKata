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
                {
                    var currentVal = RomanCharacterValue(value[i]);

                    if (i + 1 < value.Length)
                    {
                        var nextVal = RomanCharacterValue(value[i + 1]);
                        if (nextVal > currentVal)
                        {
                            numericValue += nextVal - currentVal;
                            i++;
                        }
                        else
                        {
                            numericValue += currentVal;
                        }
                    }
                    else
                    {
                        numericValue += currentVal;
                    }
                }
            }

            return numericValue;
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
