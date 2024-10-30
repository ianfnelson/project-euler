using System.Numerics;
using EulerLib.Extensions;

namespace EulerLib.Problems;

public class Problem0020 : IProblem
{
    public int Id => 20;
    public string Title => "Factorial Digit Sum";
    public string Solve()
    {
        var x = new BigInteger(1);

        for (var i = 1; i <= 100; i++)
        {
            x = i * x;
        }

        return x.SumOfDigits().ToString();
    }

    public string Md5OfSolution => "443cb001c138b2561a0d90720d6ce111";
}