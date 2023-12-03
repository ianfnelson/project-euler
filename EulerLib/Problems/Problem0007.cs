using EulerLib.Sequences;

namespace EulerLib.Problems;

public class Problem0007 : IProblem
{
    public int Id => 7;

    public string Title => "10001st Prime";

    public string Solve()
    {
        return PrimeInPosition(10001).ToString();
    }

    public string Md5OfSolution => "8c32ab09ec0210af60d392e9b2009560";

    public static long PrimeInPosition(int position)
    {
        return new PrimeNumbers().GenerateToMaximumSize(position).Last();
    }
}