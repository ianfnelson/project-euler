using EulerLib.Sequences;

namespace EulerLib.Problems;

public class Problem0050 : IProblem
{
    public int Id => 50;
    public string Title => "Consecutive Prime Sum";

    private static HashSet<long> _primesHashSet = [];
    private static List<long> _primesList = [];
    
    public string Solve()
    {
        const long maxValue = 1000000L;
        _primesList = new PrimeNumbers().GenerateToMaximumValue(maxValue).ToList();
        _primesHashSet = _primesList.ToHashSet();

        var maxSum = 953L;
        var termsCount = 21;

        for (int i = 0; i < _primesList.Count; i++)
        {
            long tempSum = 0L;
            for (int j = i; j < _primesList.Count; j++)
            {
                tempSum += _primesList[j];
                if (tempSum > maxValue) break;

                if (j - i + 1 > termsCount && _primesHashSet.Contains(tempSum))
                {
                    termsCount = j - i + 1;
                    maxSum = tempSum;
                }
            }
        }

        return maxSum.ToString();
    }

    public string Md5OfSolution => "73229bab6c5dc1c7cf7a4fa123caf6bc";
}