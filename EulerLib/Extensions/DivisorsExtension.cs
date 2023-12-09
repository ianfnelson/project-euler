namespace EulerLib.Extensions;

public static class DivisorsExtension
{
    public static IEnumerable<long> ProperDivisors(this int n)
    {
        return ProperDivisors((long) n);
    }

    public static IEnumerable<long> ProperDivisors(this long n)
    {
        return Divisors(n).Where(x => x != n);
    }

    public static IEnumerable<long> Divisors(this int n)
    {
        return Divisors((long) n);
    }

    public static IEnumerable<long> Divisors(this long n)
    {
        var upperBound = Math.Sqrt(n);

        for (var candidate = 1; candidate <= upperBound; candidate++)
        {
            if (n % candidate != 0)
            {
                continue;
            }

            yield return candidate;
            if (Math.Abs(candidate - upperBound) > 0.1D)
            {
                yield return n / candidate;
            }
        }
    }
}