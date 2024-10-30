using EulerLib.Extensions;
using EulerLib.Sequences;

namespace EulerLib.Problems;

public class Problem0035 : IProblem
{
    public int Id => 35;
    public string Title => "Circular Primes";

    private HashSet<int> _primesUnderOneMillion = [];
    public string Solve()
    {
        PrecalculatePrimes();
        
        return _primesUnderOneMillion
            .Count(IsCircularPrime)
            .ToString();
    }

    private bool IsCircularPrime(int trialPrime)
    {
        return trialPrime.DigitRotations().All(_primesUnderOneMillion.Contains);
    }

    private void PrecalculatePrimes()
    {
        _primesUnderOneMillion = 
            new PrimeNumbers().GenerateToMaximumValue(1000000-1)
                .Select(x => (int)x)
                .ToHashSet();
    }

    public string Md5OfSolution => "b53b3a3d6ab90ce0268229151c9bde11";
}