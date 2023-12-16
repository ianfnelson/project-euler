﻿using System.Numerics;

namespace EulerLib.Extensions;

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
    
    public static IEnumerable<int> Digits(this int number)
    {
        if (number == 0)
        {
            yield return 0;
            yield break;
        }
        
        while (number > 0)
        {
            var digit = number % 10;
            yield return digit;
            number /= 10;
        }
    }
}