using System.Collections.Generic;
using System.Linq;
using EulerLib.Extensions;

namespace EulerLib.Problems
{
    public class Problem0021 : IProblem
    {
        public int Id
        {
            get { return 21; }
        }

        public string Title { get { return "Amicable Numbers"; } }

        public string Solve()
        {
            return SumOfAmicableNumbersBelow(10000).ToString();
        }

        public long SumOfAmicableNumbersBelow(int n)
        {
            var divisorSums = new Dictionary<long, long>();

            for (var i = 2; i < n; i++)
            {
                divisorSums.Add(i, i.ProperDivisors().Sum());
            }

            var result =
                divisorSums.Where(d => d.Value > 1 && d.Value <= n)
                    .Where(
                        a => divisorSums[a.Value] == a.Key && a.Key != a.Value)
                    .Sum(x => x.Key);

            return result;
        }

        public string Md5OfSolution
        {
            get { return "51e04cd4e55e7e415bf24de9e1b0f3ff"; }
        }
    }
}