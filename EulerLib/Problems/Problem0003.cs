using System.Linq;
using EulerLib.Extensions;

namespace EulerLib.Problems
{
    public class Problem0003 : IProblem
    {
        public int Id
        {
            get { return 3; }
        }

        public string Title
        {
            get { return "Largest prime factor"; }
        }

        public string Solve()
        {
            return LargestPrimeFactorOf(600851475143).ToString();
        }

        public string Md5OfSolution
        {
            get { return "94c4dd41f9dddce696557d3717d98d82"; }
        }

        public long LargestPrimeFactorOf(long value)
        {
            return value.PrimeFactors().Max();
        }
    }
}