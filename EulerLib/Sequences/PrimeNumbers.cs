using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerLib.Sequences
{
    public class PrimeNumbers : ISequenceGenerator<long>
    {
        public IEnumerable<long> Generate()
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

        public IEnumerable<long> GenerateToMaximumValue(long maximumValue)
        {
            if (maximumValue <= 30000)
            {
                return Generate().TakeWhile(value => value <= maximumValue);
            }
            return GenerateUsingEratosthenesSieve(maximumValue);
        }

        public IEnumerable<long> GenerateToMaximumValue(int maximumValue)
        {
            return GenerateToMaximumValue((long) maximumValue);
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

        public IEnumerable<long> GenerateToMaximumSize(int maximumSize)
        {
            return GenerateToMaximumSize((long) maximumSize);
        }

        public IEnumerable<long> GenerateUsingEratosthenesSieve(long limit)
        {
            var sieve = new bool[limit + 1];
            sieve[1] = true;
            for (long j = 2; j <= limit; j++)
            {
                if (!sieve[j])
                {
                    for (long p = 2; (p * j) <= limit; p++)
                    {
                        sieve[p * j] = true;
                    }
                }
            }

            for (long j = 2; j <= limit; j++)
            {
                if (!sieve[j])
                {
                    yield return j;
                }
            }
        }
    }
}