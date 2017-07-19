using System.Linq;
using System.Numerics;
using EulerLib.Extensions;

namespace EulerLib.Problems
{
    public class Problem0056 : IProblem
    {
        public int Id => 56;
        public string Title => "Powerful Digital Sum";
        public string Solve()
        {
            int maxPowerDigitalSum = 0;

            for (int a = 1; a < 100; a++)
            {
                BigInteger running = a;
                int b = 1;

                do
                {
                    int powerDigitalSum = (int)running.SumOfDigits();
                    if (powerDigitalSum > maxPowerDigitalSum)
                    {
                        maxPowerDigitalSum = powerDigitalSum;
                    }

                    b++;
                    running = running * a;
                } while (b<=100);

            }
            return maxPowerDigitalSum.ToString();
        }

        public string Md5OfSolution => "c22abfa379f38b5b0411bc11fa9bf92f";

    }
}