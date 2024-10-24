using EulerLib.Extensions;

namespace EulerLib.Problems;

public class Problem0036 : IProblem
{
    public int Id => 36;
    public string Title => "Double-base Palindromes";
    public string Solve()
    {
        return Enumerable.Range(1, 1000000)
            .Where(x => x.IsPalindromic())
            .Where(x => Convert.ToString(x, 2).IsPalindromic())
            .Sum()
            .ToString();
    }

    public string Md5OfSolution => "0e175dc2f28833885f62e7345addff03";
}