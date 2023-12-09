namespace EulerLib.Extensions;

public static class PrimeFactorsExtension
{
    public static IEnumerable<long> PrimeFactors(this int n)
    {
        return PrimeFactors((long) n);
    }

    public static IEnumerable<long> PrimeFactors(this long n)
    {
        if (n == 1) yield break;

        while (n % 2 == 0)
        {
            yield return 2;
            n /= 2;
        }

        var trialDivisor = 3;

        while (trialDivisor * trialDivisor <= n)
        {
            if (n % trialDivisor == 0)
            {
                yield return trialDivisor;
                n /= trialDivisor;
            }
            else
            {
                trialDivisor += 2;
            }
        }

        if (n > 1) yield return n;
    }
}