using EulerLib.Extensions;
using EulerLib.Sequences;

namespace EulerLib.Problems;

public class Problem0012 : IProblem
{
    public int Id => 12;

    public string Title => "Highly divisible triangular number";

    public string Solve()
    {
        return FirstTriangularNumberWithMoreThanXDivisors(500).ToString();
    }

    public long FirstTriangularNumberWithMoreThanXDivisors(int divisors)
    {
        return new TriangularNumbers()
            .Generate()
            .First(x => x.Divisors().Count() > divisors);
    }

    public string Md5OfSolution => "8091de7d285989bbfa9a2f9f3bdcc7c0";
}