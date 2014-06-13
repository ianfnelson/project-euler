using System.Numerics;
using EulerLib.Extensions;

namespace EulerLib.Problems
{
    public class Problem0016 : IProblem
    {
        public int Id
        {
            get { return 16; }
        }

        public string Title
        {
            get { return "Power digit sum"; }
        }

        public string Solve()
        {
            return PowerDigitSum(2, 1000).ToString();
        }

        public int PowerDigitSum(int value, int exponent)
        {
            return (int)BigInteger.Pow(new BigInteger(value), exponent).SumOfDigits();
        }

        public string Md5OfSolution
        {
            get { return "6a5889bb0190d0211a991f47bb19a777"; }
        }
    }
}