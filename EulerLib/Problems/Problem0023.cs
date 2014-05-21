using System;
using System.Collections.Generic;
using System.Linq;
using EulerLib.Extensions;
using EulerLib.Sequences;

namespace EulerLib.Problems
{
    public class Problem0023 : IProblem
    {
        public int Id
        {
            get { return 23; }
        }

        public string Title
        {
            get { return "Non-Abundant Sums"; }
        }

        public string Solve()
        {
            return SumOfNonAbundantsBelow(28123).ToString();
        }

        public int SumOfNonAbundantsBelow(int n)
        {
            var abundants = new AbundantNumbers().GenerateToMaximumValue(n).ToHashSet();

            var total = 0;

            for (var i = n; i >= 1; i--)
            {
                if (!IsSumOfTwoFromSet(abundants, i))
                {
                    total += i;
                }
            }

            return total;
        }

        private static bool IsSumOfTwoFromSet(ISet<long> set, long n)
        {
            return set
                .Where(a => a < n)
                .Any(b => set.Contains(n - b));
        }

        public string Md5OfSolution { get { return "2c8258c0604152962f7787571511cf28"; } }
    }
}