using System;
using EulerLib.Extensions;

namespace EulerLib.Problems
{
    public class Problem0004 : IProblem
    {
        public int Id
        {
            get { return 4; }
        }

        public string Title
        {
            get { return "Largest palindrome product"; }
        }

        public string Solve()
        {
            return LargestPalindromeMadeFromProductOfTwoIntegersWithDigits(3).ToString();
        }

        public long LargestPalindromeMadeFromProductOfTwoIntegersWithDigits(int digits)
        {
            if (digits<1) throw new ArgumentOutOfRangeException("digits", "digits must be 1 or more");

            var min = 1;
            while (digits != 1)
            {
                min *= 10;
                digits--;
            }

            var biggest = 0;

            var max = (min * 10) - 1;

            for (var outer = min; outer <= max; outer++)
            {
                for (var inner = outer; inner <= max; inner++)
                {
                    var product = inner * outer;
                    if (product < biggest) continue;
                    if (!product.IsPalindromic()) continue;

                    biggest = product;
                }
            }

            return biggest;
        }
    }
}