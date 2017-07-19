using System.Globalization;
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

        public static BigInteger Reverse(this BigInteger n)
        {
            var stringyN = n.ToString(CultureInfo.InvariantCulture);

            var reverseStringyN = stringyN.ReverseString();

            return BigInteger.Parse(reverseStringyN);

        }
    }
}