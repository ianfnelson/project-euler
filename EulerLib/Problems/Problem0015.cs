using System.Numerics;
using EulerLib.Extensions;

namespace EulerLib.Problems;

public class Problem0015 : IProblem
{
    public int Id => 15;

    public string Title => "Lattice Paths";

    public string Solve()
    {
        return PathsThroughGridWithSideLength(20).ToString();
    }

    public BigInteger PathsThroughGridWithSideLength(int sideLength)
    {
        var n = sideLength*2;
        var k = sideLength;

        var binomialCoefficient = n.Factorial()/(k.Factorial()*(n - k).Factorial());

        return binomialCoefficient;
    }

    public string Md5OfSolution => "928f3957168ac592c4215dcd04e0b678";
}