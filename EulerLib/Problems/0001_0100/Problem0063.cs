using System.Numerics;

namespace EulerLib.Problems;

public class Problem0063 : IProblem
{
    public int Id => 63;
    public string Title => "Powerful Digit Counts";
    public string Solve()
    {
        var count = 0;
        
        for (var i = 1; i <= 9; i++)
        {
            for (var e = 1; e <= 28; e++)
            {
                var power = BigInteger.Pow(i, e);
                if (power.ToString().Length == e)
                {
                    count++;
                }
            }
        }
        
        return count.ToString();
    }

    public string Md5OfSolution => "f457c545a9ded88f18ecee47145a72c0";
}