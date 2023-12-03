using EulerLib.Sets;

namespace EulerLib.Problems;

public class Problem0043 : IProblem
{
    public int Id => 43;
    public string Title => "Sub-string Divisibility";
    public string Solve()
    {
        return PandigitalNumbers
            .Generate(0, 9)
            .Where(HasDesiredProperty)
            .Sum(long.Parse)
            .ToString();
    }

    public static bool HasDesiredProperty(string pandigital)
    {
        return int.Parse(pandigital.Substring(7, 3)) % 17 == 0
               && int.Parse(pandigital.Substring(6, 3)) % 13 == 0
               && int.Parse(pandigital.Substring(5, 3)) % 11 == 0
               && int.Parse(pandigital.Substring(4, 3)) % 7 == 0
               && int.Parse(pandigital.Substring(3, 3)) % 5 == 0
               && int.Parse(pandigital.Substring(2, 3)) % 3 == 0
               && int.Parse(pandigital.Substring(1, 3)) % 2 == 0;
    }

    public string Md5OfSolution => "115253b7721af0fdff25cd391dfc70cf";
}