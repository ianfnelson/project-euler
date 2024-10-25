using EulerLib.Sequences;

namespace EulerLib.Problems;

public class Problem0045 : IProblem
{
    public int Id => 45;
    public string Title => "Triangular, Pentagonal, and Hexagonal";
    public string Solve()
    {
        var upperBound = 50000;
        var pentagonals = new PentagonalNumbers().GenerateToMaximumSize(upperBound).ToHashSet();

        var maxpent = pentagonals.Max();
        
        foreach (var hexagonal in new HexagonalNumbers().Generate())
        {
            if (hexagonal <= 40755) continue;

            if (pentagonals.Contains(hexagonal))
            {
                return hexagonal.ToString();
            }

            if (hexagonal > maxpent)
            {
                throw new InvalidOperationException("Shouldn't get to here - increase upper bound");
            }
        }

        throw new InvalidOperationException("Shouldn't get to here");
    }

    public string Md5OfSolution => "30dfe3e3b286add9d12e493ca7be63fc";
}