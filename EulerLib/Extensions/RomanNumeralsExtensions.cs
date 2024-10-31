namespace EulerLib.Extensions;

public static class RomanNumeralsExtensions
{
    private static readonly Dictionary<char, int> RomanToIntegers = new()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };
    
    private static readonly List<(int value, string numeral)> IntegerToRomans =
    [
        (1000, "M"),
        (900, "CM"),
        (500, "D"),
        (400, "CD"),
        (100, "C"),
        (90, "XC"),
        (50, "L"),
        (40, "XL"),
        (10, "X"),
        (9, "IX"),
        (5, "V"),
        (4, "IV"),
        (1, "I")
    ];
    
    public static int ParseRomanNumeral(this string roman)
    {
        var total = 0;
        var previousValue = 0;

        foreach (var numeral in roman)
        {
            if (!RomanToIntegers.TryGetValue(numeral, out var currentValue))
            {
                throw new ArgumentException($"Invalid Roman numeral character: {numeral}");
            }

            if (currentValue > previousValue)
            {
                total += currentValue - 2 * previousValue;
            }
            else
            {
                total += currentValue;
            }

            previousValue = currentValue;
        }

        return total;
    }
    
    public static string ToRomanNumeral(this int number)
    {
        if (number is < 1 or > 4999)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "Input must be between 1 and 4999.");
        }

        var result = new System.Text.StringBuilder();

        foreach (var (value, numeral) in IntegerToRomans)
        {
            while (number >= value)
            {
                result.Append(numeral);
                number -= value;
            }
        }

        return result.ToString();
    }

    public static string SimplifyRomanNumeral(this string roman)
    {
        return roman.ParseRomanNumeral().ToRomanNumeral();
    }
}