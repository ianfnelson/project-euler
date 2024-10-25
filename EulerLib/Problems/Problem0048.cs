using System.Numerics;

namespace EulerLib.Problems;

public class Problem0048 : IProblem
{
    public int Id => 48;
    public string Title => "Self Powers";
    public string Solve()
    {
        BigInteger tenToTen = BigInteger.Pow(10, 10);
        BigInteger runningTotal = 0;

        for (var i = 1; i <= 1000; i++)
        {
            runningTotal += BigInteger.Pow(i, i);
            runningTotal %= tenToTen;
        }
        
        return runningTotal.ToString(); 
    }

    public string Md5OfSolution => "0829124724747ae1c65da8cae5263346";
}