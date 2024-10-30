using EulerLib.Extensions;

namespace EulerLib.Problems;

public class Problem0047 : IProblem
{
    public int Id => 47;
    public string Title => "Distinct Primes Factors";
    public string Solve()
    {
        return FirstOfNConsecutiveIntegersWithNDistinctPrimeFactors(4).ToString();
    }

    public string Md5OfSolution => "748f517ecdc29106e2738f88aa7530f4";

    public int DistinctPrimeFactors(int value)
    {
        var factors = value.PrimeFactors();

        return factors.Distinct().Count();
    }

    public int FirstOfNConsecutiveIntegersWithNDistinctPrimeFactors(int n)
    {
        int? firstInSequence = null;
        int valueUnderTest = 0;

        do
        {
            valueUnderTest++;

            var distinctPrimeFactorCount = DistinctPrimeFactors(valueUnderTest);

            if (distinctPrimeFactorCount == n)
            {
                if (firstInSequence == null)
                {
                    firstInSequence = valueUnderTest;
                }
            }
            else
            {
                firstInSequence = null;
            }

        } while (firstInSequence==null || valueUnderTest - firstInSequence != n-1);

        return firstInSequence.Value;
    }
}