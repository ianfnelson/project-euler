using EulerLib.Sequences;

namespace EulerLib.Problems;

public class Problem0049 : IProblem
{
    public int Id => 49;
    public string Title => "Prime Permutations";

    private HashSet<int> _fourDigitPrimes = [];
    public string Solve()
    {
        _fourDigitPrimes = new PrimeNumbers()
            .GenerateToMaximumValue(9999)
            .Select(x => (int)x)
            .ToList()
            .Where(x => x >= 1000)
            .Where(x => x != 1487)
            .ToHashSet();
        
        foreach (var prime in _fourDigitPrimes)
        {
            for (var increment = 2; increment < (9999-prime)/2; increment+=2)
            {
                var n2 = prime + increment;
                var n3 = n2 + increment;

                if (HasDesiredProperty(prime, n2, n3))
                {
                    return String.Format("{0}{1}{2}", prime, n2, n3);
                }
            }
        }
        
        throw new InvalidOperationException("Should not reach here");
    }

    private bool HasDesiredProperty(int prime, int n2, int n3)
    {
        return _fourDigitPrimes.Contains(n2) &&
               _fourDigitPrimes.Contains(n3) &&
               ArePermutations(prime, n2) &&
               ArePermutations(prime, n3);
    }

    private static bool ArePermutations(int num1, int num2)
    {
        // Convert both numbers to strings
        var str1 = num1.ToString();
        var str2 = num2.ToString();

        // If the lengths are not equal, they cannot be permutations
        if (str1.Length != str2.Length)
            return false;

        // Sort the characters of both strings and compare them
        return string.Concat(str1.OrderBy(c => c)) == string.Concat(str2.OrderBy(c => c));
    }

    public string Md5OfSolution => "0b99933d3e2a9addccbb663d46cbb592";
}