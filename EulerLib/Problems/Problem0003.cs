using EulerLib.Extensions;

namespace EulerLib.Problems;

public class Problem0003 : IProblem
{
    public int Id => 3;

    public string Title => "Largest prime factor";

    public string Solve()
    {
        return LargestPrimeFactorOf(600851475143).ToString();
    }

    public string Md5OfSolution => "94c4dd41f9dddce696557d3717d98d82";

    public long LargestPrimeFactorOf(long value)
    {
        return value.PrimeFactors().Max();
    }
}