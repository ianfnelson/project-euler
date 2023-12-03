using EulerLib.Extensions;
using EulerLib.Sets;

namespace EulerLib.Problems;

public class Problem0041 : IProblem
{
    public int Id => 41;
    public string Title => "Pandigital Prime";
    public string Solve()
    {
        // 1 to n Pandigitals with 8 or 9 digits are always divisible by 3
        return PandigitalNumbers
            .Generate(1, 7)
            .OrderDescending()
            .Select(long.Parse)
            .First(x => x.IsPrime())
            .ToString();
    }

    public string Md5OfSolution => "7652413";
}