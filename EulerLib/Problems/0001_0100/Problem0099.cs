namespace EulerLib.Problems;

public class Problem0099 : IProblem
{
    public int Id => 99;
    public string Title => "Largest Exponential";
    public string Solve()
    {
        var winningLine = 0;
        double winner = 0;
        
        foreach (var line in ParseInputFile("ContentFiles/problem0099.txt"))
        {
            var val = line.Exponent * Math.Log10(line.Base);
            if (val > winner)
            {
                winner = val;
                winningLine = line.LineNumber;
            }
        }
        
        return winningLine.ToString();
    }
    
    private static IEnumerable<Line> ParseInputFile(string filePath)
    {
        int lineNumber = 0;

        foreach (var line in File.ReadLines(filePath))
        {
            lineNumber++;
            var values = line.Split(',');
            yield return new Line(lineNumber,int.Parse(values[0]), int.Parse(values[1]) );
        }
    }

    private class Line(int lineNumber, int @base, int exponent)
    {
        public int LineNumber { get; } = lineNumber;

        public int Base { get; } = @base;

        public int Exponent { get; } = exponent;
    }

    public string Md5OfSolution => "1ecfb463472ec9115b10c292ef8bc986";
}