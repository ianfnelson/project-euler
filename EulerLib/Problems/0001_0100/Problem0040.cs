using System.Text;

namespace EulerLib.Problems;

public class Problem0040 : IProblem
{
    public int Id => 40;
    public string Title => "Champernowne's Constant";
    public string Solve()
    {
        var sb = new StringBuilder();
        int counter = 1;
        do
        {
            sb.Append(counter++.ToString());
        } while (sb.Length < 1000000);
        
        var output = sb.ToString();

        var result = Dn(output, 1)
                     * Dn(output, 10)
                     * Dn(output, 100)
                     * Dn(output, 1000)
                     * Dn(output, 10000)
                     * Dn(output, 100000)
                     * Dn(output, 1000000);

        return result.ToString();
    }

    private static int Dn(string output, int n)
    {
        return int.Parse(output.Substring(n - 1, 1));
    }

    public string Md5OfSolution => "6f3ef77ac0e3619e98159e9b6febf557";
}