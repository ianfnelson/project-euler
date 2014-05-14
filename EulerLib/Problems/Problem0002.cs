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

        public int SumEvenFibonacciWithValuesNotExceeding(int maxValue)
        {
            return new FibonacciNumbers().GenerateToMaximumValue(maxValue)
                                         .Where(x => x%2 == 0)
                                         .Sum();
        }
    }
}