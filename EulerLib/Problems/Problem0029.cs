using System.Numerics;

namespace EulerLib.Problems;

public class Problem0029 : IProblem
{
    public int Id => 29;

    public string Title => "Distinct Powers";

    public string Solve()
    {
        return CountDistinctPowersThrough(100).ToString();
    }

    public static int CountDistinctPowersThrough(int n)
    {
        var terms = new HashSet<BigInteger>();

        for (BigInteger a = 2; a <= n; a++)
        {
            for (var b = 2; b <= n; b++)
            {
                terms.Add(BigInteger.Pow(a,b));
            }
        }

        return terms.Count;
    }

    public string Md5OfSolution => "6f0ca67289d79eb35d19decbc0a08453";
}