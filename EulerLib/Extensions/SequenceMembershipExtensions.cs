﻿using System.Globalization;
using System.Linq;

namespace EulerLib.Extensions
{
    public static class SequenceMembershipExtensions
    {
        public static bool IsAbundant(this int n)
        {
            return IsAbundant((long) n);
        }

        public static bool IsPerfect(this int n)
        {
            return IsPerfect((long) n);
        }

        public static bool IsDeficient(this int n)
        {
            return IsDeficient((long) n);
        }

        public static bool IsPrime(this int n)
        {
            return IsPrime((long) n);
        }

        public static bool IsAbundant(this long n)
        {
            return n.ProperDivisors().Sum() > n;
        }

        public static bool IsPerfect(this long n)
        {
            return n.ProperDivisors().Sum() == n;
        }

        public static bool IsDeficient(this long n)
        {
            return n.ProperDivisors().Sum() < n;
        }

        public static bool IsPrime(this long n)
        {
            return n > 1 && n.Divisors().All(x => (x == n) || (x == 1));
        }

        public static bool IsPalindromic(this int n)
        {
            return IsPalindromic((long) n);
        }

        public static bool IsPalindromic(this long n)
        {
            var stringyN = n.ToString(CultureInfo.InvariantCulture);

            return stringyN.Equals(stringyN.ReverseString());
        }
    }
}