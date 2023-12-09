using EulerLib.Sequences;

namespace EulerLib.Problems;

public class Problem0037 : IProblem
{
    public int Id => 37;
    public string Title => "Truncatable Primes";
    
    private static readonly HashSet<long> Primes = new();
    
    public string Solve()
    {
        var trIndex = 0;
        var total = 0L;

        foreach (var prime in new PrimeNumbers().Generate())
        {
            Primes.Add(prime);

            if (!IsTruncatablePrime(prime)) continue;

            trIndex++;
            total += prime;

            if (trIndex == 11) break;
        }

        return total.ToString();
    }

    public string Md5OfSolution => "cace46c61b00de1b60874936a093981d";
    
    public static bool IsTruncatablePrime(long prime)
    {
        if (prime <= 7) return false;

        return GetTruncatedValues(prime).All(x => Primes.Contains(x));
    }

    public static IEnumerable<long> GetTruncatedValues(long n)
    {
        var trunks = new List<string>();

        var nstr = n.ToString();

        for (int ltr = 1; ltr <= nstr.Length-1; ltr++)
        {
            trunks.Add(nstr[ltr..]);
        }

        for (int rtl = nstr.Length-1; rtl >= 1; rtl--)
        {
            trunks.Add(nstr[..rtl]);
        }

        return trunks.Select(x => Convert.ToInt64(x)).Distinct();
    }
}