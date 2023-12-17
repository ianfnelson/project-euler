using EulerLib.Sets;

namespace EulerLib.Problems;

public class Problem0032 : IProblem
{
    public int Id => 32;
    public string Title => "Pandigital Products";
    public string Solve()
    {
        var products = new HashSet<int>();

        foreach (var identity in GetDesiredIdentities())
        {
            products.Add(identity.Product);
        }

        return products.Sum().ToString();
    }

    private static IEnumerable<Identity> GetDesiredIdentities()
    {
        return GetTrialIdentities()
            .Where(trialIdentity => trialIdentity.Multiplier * trialIdentity.Multiplicand == trialIdentity.Product);
    }

    private static IEnumerable<Identity> GetTrialIdentities()
    {
        var pandigitals = PandigitalNumbers.Generate(1, 9);
        
        // I assert that we only need to consider the cases where d * dddd = dddd or dd * ddd = dddd.
        // Other groupings of digits are not arithmetically possible, or will be covered in different orders.
        foreach (var pandigital in pandigitals)
        {
            yield return new Identity(
                int.Parse(pandigital.Substring(0,1)),
                int.Parse(pandigital.Substring(1,4)),
                int.Parse(pandigital.Substring(5,4)));
            
            yield return new Identity(
                int.Parse(pandigital.Substring(0,2)),
                int.Parse(pandigital.Substring(2,3)),
                int.Parse(pandigital.Substring(5,4)));
        }
    }

    private class Identity(int multiplicand, int multiplier, int product)
    {
        public int Multiplicand { get; } = multiplicand;
        public int Multiplier { get; } = multiplier;
        public int Product { get; } = product;
    }

    public string Md5OfSolution => "100f6e37d0b0564490a2ee27eff0660d";
}