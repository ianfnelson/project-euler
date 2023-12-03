using EulerLib.Sequences;

namespace EulerLib.Problems;

public class Problem0010 : IProblem
{
    public int Id => 10;

    public string Title => "Summation of Primes";

    public string Solve()
    {
        return SumOfPrimesBelow(2000000).ToString();
    }

    public long SumOfPrimesBelow(int ceiling)
    {
        return new PrimeNumbers().GenerateUsingEratosthenesSieve(ceiling - 1).Sum();
    }

    public string Md5OfSolution => "d915b2a9ac8749a6b837404815f1ae25";
}