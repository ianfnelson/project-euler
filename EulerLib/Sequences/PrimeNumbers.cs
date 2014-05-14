using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerLib.Sequences
{
    public class PrimeNumbers
    {
        public IEnumerable<int> Generate()
        {
            HashSet<int> primes = new HashSet<int>(){2};

            yield return 2;

            var trialPrime = 3;

            do
            {
                var upperBound = Math.Sqrt(trialPrime);
                bool isPrime = true;

                foreach(int trialDivisor in primes)
                {
                    if (trialDivisor>upperBound) break;

                    if (trialPrime % trialDivisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primes.Add(trialPrime);
                    yield return trialPrime;
                }

                trialPrime+= 2;
            } while (true);

        }

        public IEnumerable<int> GenerateToMaximumValue(int maximumValue)
        {
            return Generate().TakeWhile(value => value <= maximumValue);
        }

        public IEnumerable<int> GenerateToMaximumSize(int maximumSize)
        {
            var x = 0;

            foreach (var value in Generate())
            {
                x++;
                if (x > maximumSize) break;
                yield return value;
            }
        }
    }
}
