﻿using EulerLib.Sequences;

namespace EulerLib.Problems;

public class Problem0023 : IProblem
{
    public int Id => 23;

    public string Title => "Non-Abundant Sums";

    public string Solve()
    {
        return SumOfNonAbundantsBelow(28123).ToString();
    }

    public int SumOfNonAbundantsBelow(int n)
    {
        var abundants = new AbundantNumbers().GenerateToMaximumValue(n).ToHashSet();

        var total = 0;

        Parallel.For(1, n, x =>
        {
            if (!IsSumOfTwoFromSet(abundants, x))
            {
                Interlocked.Add(ref total, x);
            }
        });

        return total;
    }

    private static bool IsSumOfTwoFromSet(ISet<long> set, long n)
    {
        return set
            .Where(a => a < n)
            .Any(b => set.Contains(n - b));
    }

    public string Md5OfSolution => "2c8258c0604152962f7787571511cf28";
}