using EulerLib.Sequences;

namespace EulerLib.Problems;

public class Problem0050 : IProblem
{
    public int Id => 50;
    public string Title => "Consecutive Prime Sum";

    private static HashSet<long> PrimesHashSet = new();
    private static List<long> PrimesList = new();
    
    public string Solve()
    {
        const long maxValue = 1000000L;
        PrimesList = new PrimeNumbers().GenerateToMaximumValue(maxValue).ToList();
        PrimesHashSet = PrimesList.ToHashSet();

        var maxSum = 953L;
        var termsCount = 21;

        for (int i = 0; i < PrimesList.Count; i++)
        {
            long tempSum = 0L;
            for (int j = i; j < PrimesList.Count; j++)
            {
                tempSum += PrimesList[j];
                if (tempSum > maxValue) break;

                if (j - i + 1 > termsCount && PrimesHashSet.Contains(tempSum))
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