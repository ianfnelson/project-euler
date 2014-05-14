using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerLib.Sequences
{
    public class PrimeNumbers
    {
        public IEnumerable<long> Generate()
        {
            var primes = new HashSet<long>(){2};

            yield return 2;

            var trialPrime = 3;

            do
            {
                var upperBound = Math.Sqrt(trialPrime);
                var isPrime = true;

                foreach(var trialDivisor in primes)
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

        public IEnumerable<long> GenerateToMaximumValue(long maximumValue)
        {
            return Generate().TakeWhile(value => value <= maximumValue);
        }

        public IEnumerable<long> GenerateToMaximumSize(long maximumSize)
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
