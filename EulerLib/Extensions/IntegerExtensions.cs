using System;
using System.Globalization;
using System.Numerics;

namespace EulerLib.Extensions
{
    public static class IntegerExtensions
    {
        public static BigInteger Factorial(this int n)
        {
            var factorial = new BigInteger(1);

            while (n >= 2)
            {
                factorial *= n;
                n--;
            }

            return factorial;
        }
    }
}