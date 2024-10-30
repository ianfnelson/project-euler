namespace EulerLib.Problems;

public class Problem0039 : IProblem
{
    public int Id => 39;
    public string Title => "Integer Right Triangles";
    public string Solve()
    {
        var winner = 0;
        var maxCount = 0;

        for (int p = 3; p <= 1000; p++)
        {
            var rightAngledTriangles = SplitThreeWays(p)
                .Count(IsRightAngledTriangle);

            if (rightAngledTriangles > maxCount)
            {
                maxCount = rightAngledTriangles;
                winner = p;
            }
        }
        
        return winner.ToString();
    }

    private static bool IsRightAngledTriangle((int, int, int) abc)
    {
        int[] sides = [abc.Item1, abc.Item2, abc.Item3];
        Array.Sort(sides);
        
        return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
    }

    private static List<(int, int, int)> SplitThreeWays(int x)
    {
        var results = new List<(int, int, int)>();

        // a >= b >= c ensures distinct combinations
        for (var a = x; a >= x / 3; a--)
        {
            for (var b = Math.Min(a, x - a); b >= (x - a) / 2; b--)
            {
                var c = x - a - b;
                if (b >= c) // Ensures the ordering a >= b >= c
                {
                    results.Add((a, b, c));
                }
            }
        }

        return results;
    }

    public string Md5OfSolution => "fa83a11a198d5a7f0bf77a1987bcd006";
}