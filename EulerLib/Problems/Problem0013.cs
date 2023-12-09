using System.Numerics;

namespace EulerLib.Problems;

public class Problem0013 : IProblem
{
    public int Id => 13;

    public string Title => "Large sum";

    public string Solve()
    {
        return SumBigIntegers("ContentFiles/problem0013.txt").ToString()[..10];
    }

    public BigInteger SumBigIntegers(string filePath)
    {
        return File.ReadLines(filePath)
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .Select(BigInteger.Parse)
            .Aggregate(BigInteger.Zero, (current, value) => current + value);
    }

    public string Md5OfSolution => "361113f19fd302adc31268f8283a4f2d";
}