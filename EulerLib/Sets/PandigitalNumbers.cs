namespace EulerLib.Sets;

public static class PandigitalNumbers
{
    public static IEnumerable<string> Generate(int startDigit, int endDigit)
    {
        var digits = GetDigitCharacters(startDigit, endDigit).ToArray();

        foreach (var permutation in Permutator.Permute(digits))
        {
            yield return permutation;
        }
    }
    
    private static IEnumerable<string> GetDigitCharacters(int startDigit, int endDigit)
    {
        for (var i = startDigit; i <= endDigit; i++)
        {
            yield return i.ToString();
        }
    }
}