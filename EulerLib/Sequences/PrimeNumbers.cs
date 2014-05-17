using System;
using System.Collections.Generic;

namespace EulerLib.Sequences
{
    public class PrimeNumbers : SequenceGeneratorBase
    {
        public override IEnumerable<long> Generate()
        {
            var primes = new HashSet<long> {2};

            yield return 2;

            var trialPrime = 3;

            do
            {
                var upperBound = Math.Sqrt(trialPrime);
                var isPrime = true;

                foreach (var trialDivisor in primes)
                {
                    if (trialDivisor > upperBound) break;

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

                trialPrime += 2;
            } while (true);
        }
    }
}