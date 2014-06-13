using System.Numerics;

namespace EulerLib.Extensions
{
    public static class BigIntegerExtensions
    {
        public static BigInteger SumOfDigits(this BigInteger value)
        {
            BigInteger sum = 0;
            while (value != BigInteger.Zero)
            {
                sum += value % 10;
                value /= 10;
            }

            return sum;
        }
    }
}