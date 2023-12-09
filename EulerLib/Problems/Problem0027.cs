using EulerLib.Sequences;

namespace EulerLib.Problems;

public class Problem0027 : IProblem
{
    public int Id => 27;
    public string Title => "Quadratic Primes";
    public string Solve()
    {
        // Build up reference data of primes
        var primes = new HashSet<long>();
        foreach (var prime in new PrimeNumbers().GenerateToMaximumValue(87400))
        {
            primes.Add(prime);
        }

        var currentConsecutivePrimes = 0;
        var currentProduct = 0;

        for (int a = -999; a < 1000; a++)
        {
            for (int b = -999; b < 1000; b++)
            {
                int n = 0;

                do
                {
                    int y = (n * n) + (a * n) + b;

                    if (!primes.Contains(y)) break;

                    n++;

                    if (n > currentConsecutivePrimes)
                    {
                        currentConsecutivePrimes = n;
                        currentProduct = a * b;
                    }

                } while (true);
            }
        }

        return currentProduct.ToString();
    }

    public string Md5OfSolution => "69d9e3218fd7abb6ff453ea96505183d";
}