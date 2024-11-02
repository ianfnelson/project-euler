using EulerLib.Extensions;
using EulerLib.Sequences;

namespace EulerLib.Problems._0801_0900;

public class Problem0808 : IProblem
{
    public int Id => 808;
    public string Title => "Reversible Prime Squares";

    private readonly List<long> _primeSquaresList;
    private readonly HashSet<string> _primeSquaresHashset;

    public Problem0808()
    {
        _primeSquaresList = new PrimeNumbers()
            .GenerateToMaximumValue(50000000)
            .Select(x => x * x)
            .ToList();
        
        _primeSquaresHashset = _primeSquaresList
            .Select(x => x.ToString())
            .ToHashSet();
    }
    public string Solve()
    {
        return _primeSquaresList
            .Where(IsReversiblePrimeSquare)
            .Take(50)
            .Sum()
            .ToString();
    }

    private bool IsReversiblePrimeSquare(long primeSquare)
    {
        return !primeSquare.IsPalindromic() &&
               _primeSquaresHashset.Contains(primeSquare.ToString().ReverseString());
    }
    

    public string Md5OfSolution => "b3026f0182a9ff9bbe9193fa55c87d03";
}