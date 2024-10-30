namespace EulerLib.Problems;

public class Problem0006 : IProblem
{
    public int Id => 6;

    public string Title => "Sum Square Difference";

    public string Solve()
    {
        return SumSquareDifferenceOfNaturalsUpTo(100).ToString();
    }

    public string Md5OfSolution => "867380888952c39a131fe1d832246ecc";

    public long SumSquareDifferenceOfNaturalsUpTo(int n)
    {
        return SquareOfSumOfNaturalsTo(n) - SumOfSquaresOfNaturalsTo(n);
    }

    public long SumOfSquaresOfNaturalsTo(int n)
    {
        return n * (n + n + 1) * (n + 1) / 6;
    }

    public long SquareOfSumOfNaturalsTo(int n)
    {
        var sum = n * (n + 1) / 2;
        return sum * sum;
    }
}