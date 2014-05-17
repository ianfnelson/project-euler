using System.Linq;
using EulerLib.Sequences;

namespace EulerLib.Problems
{
    public class Problem0007 : IProblem
    {
        public int Id
        {
            get { return 7; }
        }

        public string Title
        {
            get { return "10001st Prime"; }
        }

        public string Solve()
        {
            return PrimeInPosition(10001).ToString();
        }

        public long PrimeInPosition(int position)
        {
            return new PrimeNumbers().GenerateToMaximumSize(position).Last();
        }
    }
}