using EulerLib.Extensions;

namespace EulerLib.Problems;

public class Problem0034 : IProblem
{
    public int Id => 34;
    public string Title => "Digit Factorials";

    private readonly Dictionary<int, int> _digitFactorials = new();
    
    public string Solve()
    {
        PrecalculateDigitFactorials();
        
        var maximumBound = 7 * (int)9.Factorial();

        return Enumerable.Range(3, maximumBound)
            .Where(IsEqualToSumOfDigitFactorials)
            .Sum()
            .ToString();
    }

    private void PrecalculateDigitFactorials()
    {
        Enumerable.Range(0, 10).ToList().ForEach(x => _digitFactorials.Add(x, (int)x.Factorial()));
    }

    private bool IsEqualToSumOfDigitFactorials(int number)
    {
        return number == number.Digits().Sum(x => _digitFactorials[x]);
    }

    public string Md5OfSolution => "60803ea798a0c0dfb7f36397d8d4d772";
}