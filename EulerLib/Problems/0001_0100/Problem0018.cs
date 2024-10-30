namespace EulerLib.Problems;

public class Problem0018 : IProblem
{
    public int Id => 18;

    public string Title => "Maximum Path Sum I";

    public string Solve()
    {
        return MaximumPathThroughTriangle("ContentFiles/problem0018.txt").ToString();
    }

    public static long MaximumPathThroughTriangle(string filePath)
    {
        var triangle = ParseFile(filePath);

        for (var row = triangle.Count-2; row >= 0; row--)
        {
            for (var cell = 0; cell < triangle[row].Length; cell++)
            {
                triangle[row][cell] += Math.Max(triangle[row + 1][cell], triangle[row + 1][cell + 1]);
            }
        }

        return triangle[0][0];
    }

    private static List<int[]> ParseFile(string filePath)
    {
        return File.ReadLines(filePath)
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .Select(ParseLine)
            .ToList();
    }

    private static int[] ParseLine(string line)
    {
        return line.Split(' ').Select(int.Parse).ToArray();
    }

    public string Md5OfSolution => "708f3cf8100d5e71834b1db77dfa15d6";
}