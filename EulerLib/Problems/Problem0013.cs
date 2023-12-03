using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;

namespace EulerLib.Problems
{
    public class Problem0013 : IProblem
    {
        public int Id
        {
            get { return 13; }
        }

        public string Title
        {
            get { return "Large sum"; }
        }

        public string Solve()
        {
            var filePath = "ContentFiles/problem0013.txt";

            return SumBigIntegers(filePath).ToString().Substring(0,10);
        }

        public BigInteger SumBigIntegers(string filePath)
        {
            return File.ReadLines(filePath)
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Select(BigInteger.Parse)
                .Aggregate(BigInteger.Zero, (current, value) => current + value);
        }

        public string Md5OfSolution
        {
            get { return "361113f19fd302adc31268f8283a4f2d"; }
        }
    }
}