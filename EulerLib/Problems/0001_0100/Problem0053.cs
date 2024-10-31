using System.Numerics;

namespace EulerLib.Problems;

public class Problem0053 : IProblem
{
    public int Id => 53;
    public string Title => "Combinatoric Selections";

    private readonly BigInteger[] _factorials = PrecalculateFactorials();
    
    public string Solve()
    {
        var count = 0;
        
        for (var n = 1; n <= 100; n++)
        {
            for (var r = 1; r <= n; r++)
            {
                if (NCr(n, r) > 1000000)
                {
                    count++;
                }
            }
        }
        
        return count.ToString();
    }

    private BigInteger NCr(int n, int r)
    {
        return _factorials[n]/(_factorials[r] * _factorials[n-r]);
    }
    
    private static BigInteger[] PrecalculateFactorials()
    {
        var factorials = new BigInteger[101];

        var x = new BigInteger(1);
        
        factorials[0] = BigInteger.One;
        
        for (var i = 1; i <= 100; i++)
        {
            x *= i;
            factorials[i] = x;
        }
        
        return factorials;
    }

    public string Md5OfSolution => "e3b21256183cf7c2c7a66be163579d37";
}