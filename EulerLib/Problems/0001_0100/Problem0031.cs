namespace EulerLib.Problems;

public class Problem0031 : IProblem
{
    private static readonly int[] CoinSizes = { 1, 2, 5, 10, 20, 50, 100, 200 };
    public int Id => 31;

    public string Title => "Coin sums";

    public string Solve()
    {
        return WaysOfMaking(200).ToString();
    }

    public string Md5OfSolution => "142dfe4a33d624d2b830a9257e96726d";

    public static int WaysOfMaking(int target)
    {
        var ways = new int[target + 1];
        ways[0] = 1;

        foreach (var t in CoinSizes)
            for (var j = t; j <= target; j++)
                ways[j] += ways[j - t];

        return ways[^1];
    }
}