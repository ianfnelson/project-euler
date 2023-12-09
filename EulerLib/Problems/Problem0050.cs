using EulerLib.Sequences;

namespace EulerLib.Problems;

public class Problem0050 : IProblem
{
    public int Id => 50;
    public string Title => "Consecutive Prime Sum";

    private static readonly HashSet<long> Primes = new();
    
    public string Solve()
    {
        foreach (var prime in new PrimeNumbers().GenerateToMaximumValue(1000000))
        {
            Primes.Add(prime);
        }

        var currentTerms = 0;
        var maxPrime = Primes.Last();
        var winner = 0L;
        
        for (int i = 0; i < Primes.Count; i++)
        {
            var j = i;
            var runningTotal = 0L;
            var terms = 0;

            while (j < Primes.Count && runningTotal < maxPrime)
            {
                runningTotal += Primes.ElementAt(j);
                terms++;

                if (terms > currentTerms && Primes.Contains(runningTotal))
                {
                    currentTerms = terms;
                    winner = runningTotal;
                }

                j++;
            }
        }

        return winner.ToString();
    }

    public string Md5OfSolution => "73229bab6c5dc1c7cf7a4fa123caf6bc";
}