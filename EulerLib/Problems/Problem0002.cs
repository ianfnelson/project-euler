using System.Linq;
using EulerLib.Sequences;

namespace EulerLib.Problems
{
    public class Problem0002 : IProblem
    {
        public int Id
        {
            get { return 2; }
        }

        public string Title
        {
            get { return "Even Fibonacci numbers"; }
        }

        public string Solve()
        {
            return SumEvenFibonacciWithValuesNotExceeding(4000000).ToString();
        }

        public string Md5OfSolution
        {
            get { return "4194eb91842c8e7e6df099ca73c38f28"; }
        }

        public long SumEvenFibonacciWithValuesNotExceeding(int maxValue)
        {
            return new FibonacciNumbers().GenerateToMaximumValue(maxValue)
                .Where(x => x % 2 == 0)
                .Sum();
        }
    }
}