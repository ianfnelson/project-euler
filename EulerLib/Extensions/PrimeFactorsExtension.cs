using System.Collections.Generic;
using EulerLib.Sequences;

namespace EulerLib.Extensions
{
    public static class PrimeFactorsExtension
    {
        public static IEnumerable<long> PrimeFactors(this int n)
        {
            return PrimeFactors((long) n);
        }

        public static IEnumerable<long> PrimeFactors(this long n)
        {
            if (n == 1) yield break;

            foreach (var prime in new PrimeNumbers().Generate())
            {
                if (n % prime == 0)
                {
                    while (n % prime == 0)
                    {
                        yield return prime;
                        n = n / prime;
                    }

                    if (n == 1) break;
                }
            }
        }
    }
}