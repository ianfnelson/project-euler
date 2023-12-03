using EulerLib.Sets;

namespace EulerLib.Problems;

public class Problem0024 : IProblem
{
    public int Id => 24;
    public string Title => "Lexicographic Permutations";
    public string Solve()
    {
        var digits = GetDigitCharacters(0, 9).ToArray();

        var loopCounter = 0;

        foreach (var permutation in Permutator.Permute(digits))
        {
            loopCounter++;
            if (loopCounter == 1000000)
            {
                return permutation;
            }
        }

        throw new InvalidOperationException("Should not reach here");
    }

    public string Md5OfSolution => "7f155b45cb3f0a6e518d59ec348bff84";
    
    private static IEnumerable<string> GetDigitCharacters(int startDigit, int endDigit)
    {
        for (var i = startDigit; i <= endDigit; i++)
        {
            yield return i.ToString();
        }
    }
}