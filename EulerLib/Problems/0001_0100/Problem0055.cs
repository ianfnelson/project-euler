using System.Numerics;
using EulerLib.Extensions;

namespace EulerLib.Problems;

public class Problem0055 : IProblem
{
    public int Id => 55;
    public string Title => "Lychrel numbers";
    public string Solve()
    {
        return LychrelNumbersBelowN(10000).ToString();
    }

    public static int LychrelNumbersBelowN(int n)
    {
        return Enumerable.Range(1, n-1).Count(IsLychrel);
    }

    public static bool IsLychrel(int n)
    {
        var iterations = 0;
        var bigN = new BigInteger(n);

        while (iterations < 50)
        {
            bigN += bigN.Reverse();

            if (bigN.IsPalindromic()) return false;

            iterations++;
        }

        return true;
    }

    public string Md5OfSolution => "077e29b11be80ab57e1a2ecabb7da330";
}