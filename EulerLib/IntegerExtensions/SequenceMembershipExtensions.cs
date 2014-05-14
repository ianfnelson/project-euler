using System;
using System.Linq;

namespace EulerLib.IntegerExtensions
{
    public static class SequenceMembershipExtensions
    {
        public static bool IsAbundant(this int n)
        {
            return n.GetProperDivisors().Sum() > n;
        }

        public static bool IsPerfect(this int n)
        {
            return n.GetProperDivisors().Sum() == n;
        }

        public static bool IsDeficient(this int n)
        {
            return n.GetProperDivisors().Sum() < n;
        }

        public static bool IsPrime(this int n)
        {
            return n > 1 && n.GetDivisors().All(x => (x == n) || (x == 1));
        }
    }
}
