using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerLib.IntegerExtensions
{
    public static class DivisorsExtension
    {
        public static IEnumerable<int> GetProperDivisors(this int n)
        {
            return GetDivisors(n).Where(x => x != n);
        }

        public static IEnumerable<int> GetDivisors(this int n)
        {
            var upperBound = Math.Sqrt(n);

            for (var candidate = 1; candidate <= upperBound; candidate++)
            {
                if (n % candidate != 0)
                {
                    continue;
                }

                yield return candidate;
                if (candidate != upperBound)
                {
                    yield return n / candidate;
                }
            }
        }
    }
}
