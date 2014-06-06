using System.Linq;
using EulerLib.Extensions;
using EulerLib.Sequences;

namespace EulerLib.Problems
{
    public class Problem0012 : IProblem
    {
        public int Id
        {
            get { return 12; }
        }

        public string Title
        {
            get { return "Highly divisible triangular number"; }
        }

        public string Solve()
        {
            return FirstTriangularNumberWithMoreThanXDivisors(500).ToString();
        }

        public long FirstTriangularNumberWithMoreThanXDivisors(int divisors)
        {
            return new TriangularNumbers()
                .Generate()
                .First(x => x.Divisors().Count() > divisors);
        }

        public string Md5OfSolution
        {
            get { return "8091de7d285989bbfa9a2f9f3bdcc7c0"; }
        }
    }
}