using EulerLib.Extensions;

namespace EulerLib.Problems;

public class Problem0004 : IProblem
{
    public int Id => 4;

    public string Title => "Largest palindrome product";

    public string Solve()
    {
        return LargestPalindromeMadeFromProductOfTwoIntegersWithDigits(3).ToString();
    }

    public string Md5OfSolution => "d4cfc27d16ea72a96b83d9bdef6ce2ec";

    public static long LargestPalindromeMadeFromProductOfTwoIntegersWithDigits(int digits)
    {
        if (digits < 1) throw new ArgumentOutOfRangeException(nameof(digits), "digits must be 1 or more");

        var min = 1;
        while (digits != 1)
        {
            min *= 10;
            digits--;
        }

        var biggest = 0;

        var max = min * 10 - 1;

        for (var outer = min; outer <= max; outer++)
        for (var inner = outer; inner <= max; inner++)
        {
            var product = inner * outer;
            if (product < biggest) continue;
            if (!product.IsPalindromic()) continue;

            biggest = product;
        }

        return biggest;
    }
}