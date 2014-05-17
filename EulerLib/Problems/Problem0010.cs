using System.Linq;
using EulerLib.Sequences;

namespace EulerLib.Problems
{
    public class Problem0010 : IProblem
    {
        public int Id
        {
            get { return 10; }
        }

        public string Title
        {
            get { return "Summation of Primes"; }
        }

        public string Solve()
        {
            return SumOfPrimesBelow(2000000).ToString();
        }

        public long SumOfPrimesBelow(int ceiling)
        {
            return new PrimeNumbers().GenerateUsingEratosthenesSieve(ceiling - 1).Sum();
        }
    }
}