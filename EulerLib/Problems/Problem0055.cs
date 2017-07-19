using System.Linq;
using System.Numerics;
using EulerLib.Extensions;

namespace EulerLib.Problems
{
    public class Problem0055 : IProblem
    {
        public int Id => 55;
        public string Title => "Lychrel numbers";
        public string Solve()
        {
            return LychrelNumbersBelowN(10000).ToString();
        }

        public int LychrelNumbersBelowN(int n)
        {
            return Enumerable.Range(1, n-1).Count(IsLychrel);
        }

        public bool IsLychrel(int n)
        {
            int iterations = 0;
            BigInteger bigN = new BigInteger(n);

            while (iterations < 50)
            {
                bigN = bigN + bigN.Reverse();

                if (bigN.IsPalindromic()) return false;

                iterations++;
            }

            return true;
        }

        public string Md5OfSolution => "x";
    }
}