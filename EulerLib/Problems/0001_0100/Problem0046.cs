using EulerLib.Sequences;

namespace EulerLib.Problems;

public class Problem0046 : IProblem
{
    public int Id => 46;
    public string Title => "Goldbach's Other Conjecture";

    private SortedSet<long> _primes = null!;
    private SortedSet<long> _doubledSquares = null!;
    public string Solve()
    {
        var upperBound = 10000;

        _primes = new SortedSet<long>(new PrimeNumbers().GenerateToMaximumValue(upperBound));
        _doubledSquares = new SortedSet<long>(new SquareNumbers().GenerateToMaximumValue(upperBound / 2)
            .Select(n => n * 2));

        for (var trial = 9; trial < upperBound; trial+=2)
        {
            // We want composites only
            if (_primes.Contains(trial)) continue;

            if (MeetsConjecture(trial))
            {
                continue;
            }
           
            return trial.ToString();
        }
        
        throw new InvalidOperationException("Should not get here - increase upper bound");
    }

    private bool MeetsConjecture(int trial)
    {
        foreach (var prime in _primes)
        {
            if (prime > trial) return false;

            if (_doubledSquares.Contains(trial - prime)) return true;
        }

        return false;
    }

    public string Md5OfSolution => "89abe98de6071178edb1b28901a8f459";
}