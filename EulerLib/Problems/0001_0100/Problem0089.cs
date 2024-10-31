using EulerLib.Extensions;

namespace EulerLib.Problems;

public class Problem0089 : IProblem
{
    public int Id => 89;
    public string Title => "Roman Numerals";
    public string Solve()
    {
        return File
            .ReadAllLines("ContentFiles/problem0089.txt")
            .Select(s => s.Length - s.SimplifyRomanNumeral().Length)
            .Sum()
            .ToString();
    }

    public string Md5OfSolution => "5c572eca050594c7bc3c36e7e8ab9550";
}