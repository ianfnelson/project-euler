using System.Text;

namespace EulerLib.Problems;

public class Problem0017 : IProblem
{
    private static readonly Dictionary<int, string> Words = new()
    {
        { 90, "ninety" },
        { 80, "eighty" },
        { 70, "seventy" },
        { 60, "sixty" },
        { 50, "fifty" },
        { 40, "forty" },
        { 30, "thirty" },
        { 20, "twenty" },
        { 19, "nineteen" },
        { 18, "eighteen" },
        { 17, "seventeen" },
        { 16, "sixteen" },
        { 15, "fifteen" },
        { 14, "fourteen" },
        { 13, "thirteen" },
        { 12, "twelve" },
        { 11, "eleven" },
        { 10, "ten" },
        { 9, "nine" },
        { 8, "eight" },
        { 7, "seven" },
        { 6, "six" },
        { 5, "five" },
        { 4, "four" },
        { 3, "three" },
        { 2, "two" },
        { 1, "one" }
    };

    public int Id => 17;
    public string Title => "Number Letter Counts";

    public string Solve()
    {
        return Enumerable.Range(1, 1000)
            .Select(NumberToWords)
            .Aggregate((a, b) => a + b)
            .Replace(" ", "")
            .Length
            .ToString();
    }
    
    public string Md5OfSolution => "6a979d4a9cf85135408529edc8a133d0";

    public static string NumberToWords(int number)
    {
        if (number is > 1000 or < 1) throw new ArgumentOutOfRangeException(nameof(number));

        if (number == 1000) return "one thousand";

        if (number >= 100)
        {
            var remainder = number % 100;
            var hundred = number / 100;

            return NumberToWords(hundred) + " hundred" + (remainder == 0 ? "" : " and " + NumberToWords(remainder));
        }

        if (number >= 20)
        {
            var remainder = number % 10;
            var tens = number - remainder;
            return Words[tens] + (remainder == 0 ? "" : NumberToWords(remainder));
        }

        return Words[number];
    }
}