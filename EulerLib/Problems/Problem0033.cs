using Fractions;

namespace EulerLib.Problems;

public class Problem0033 : IProblem
{
    public int Id => 33;
    public string Title => "Digit Cancelling Fractions";
    public string Solve()
    {
        var fourFractions = GetTrialFractions().Where(IsNonTrivialDigitCancellingFraction).ToList();

        var product = new Fraction(1, 1);
        foreach (var fraction in fourFractions)
        {
            product = product.Multiply(fraction);
        }

        return product.Denominator.ToString();
    }   

    private static IEnumerable<Fraction> GetTrialFractions()
    {
        foreach (var numerator in Enumerable.Range(12, 86))
        {
            foreach (var denominator in Enumerable.Range(numerator+1, 86))
            {
                yield return new Fraction(numerator, denominator, false);
            }
        }
    }

    private static bool IsNonTrivialDigitCancellingFraction(Fraction fraction)
    {
        var numeratorString = fraction.Numerator.ToString();
        var denominatorString = fraction.Denominator.ToString();

        var parts = new[] { numeratorString, denominatorString };
        if (parts.Any(x => x.EndsWith("0"))) return false;
        if (parts.Any(x => x[0] == x[1])) return false;
        if (numeratorString.ToCharArray().All(x => denominatorString.ToCharArray().Contains(x))) return false;
        if (numeratorString.ToCharArray().All(x => !denominatorString.ToCharArray().Contains(x))) return false;

        var commonCharacter = string.Join("",
            numeratorString.ToCharArray().Where(x => denominatorString.ToCharArray().Contains(x)));
        
        var newNumerator = int.Parse(numeratorString.Replace(commonCharacter, ""));
        var newDenominator = int.Parse(denominatorString.Replace(commonCharacter, ""));
        
        var newFraction = new Fraction(newNumerator, newDenominator);
        
        return fraction.IsEquivalentTo(newFraction);
    }

    public string Md5OfSolution => "f899139df5e1059396431415e770c6dd";
}