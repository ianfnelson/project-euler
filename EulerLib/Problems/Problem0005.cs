using EulerLib.Extensions;

namespace EulerLib.Problems;

public class Problem0005 : IProblem
{
    public int Id => 5;

    public string Title => "Smallest multiple";

    public string Solve()
    {
        return SmallestIntegerEvenlyDivisibleByNumbersFrom1To(20).ToString();
    }

    public string Md5OfSolution => "bc0d0a22a7a46212135ed0ba77d22f3a";

    public long SmallestIntegerEvenlyDivisibleByNumbersFrom1To(int maximum)
    {
        var primeFactorsAndMaxOccurrencesForEachDivisor = 
            Enumerable.Range(1, maximum)
                .SelectMany(x => x.PrimeFactors()
                    .GroupBy(pf => pf)
                    .Select(g => new {PrimeFactor = g.Key, Count = g.Count()}))
                .GroupBy(y => y.PrimeFactor)
                .Select(z => new {PrimeFactor = z.Key, MaxCount = z.Max(q => q.Count)});

        long total = 1;

        foreach (var pf in primeFactorsAndMaxOccurrencesForEachDivisor)
        {
            for (var i = 1; i <= pf.MaxCount; i++)
            {
                total *= pf.PrimeFactor;
            }
        }

        return total;

    }
}