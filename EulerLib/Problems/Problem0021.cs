using EulerLib.Extensions;

namespace EulerLib.Problems;

public class Problem0021 : IProblem
{
    public int Id => 21;

    public string Title => "Amicable Numbers";

    public string Solve()
    {
        return SumOfAmicableNumbersBelow(10000).ToString();
    }

    public string Md5OfSolution => "51e04cd4e55e7e415bf24de9e1b0f3ff";

    private static long SumOfAmicableNumbersBelow(int n)
    {
        var divisorSums = new Dictionary<long, long>();

        for (var i = 2; i < n; i++) divisorSums.Add(i, i.ProperDivisors().Sum());

        var result =
            divisorSums.Where(d => d.Value > 1 && d.Value <= n)
                .Where(
                    a => divisorSums[a.Value] == a.Key && a.Key != a.Value)
                .Sum(x => x.Key);

        return result;
    }
}