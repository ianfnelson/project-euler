using EulerLib.Extensions;
using EulerLib.Sequences;

namespace EulerLib.Problems;

public class Problem0058 : IProblem
{
    public int Id => 58;
    public string Title => "Spiral Primes";
    
    public string Solve()
    {
        int sideLength = 1;
        long cornerValue = 1;
        int primesCount = 0;
        int diagonalCount = 1;

        do
        {
            sideLength += 2;
            for (var i = 1; i <= 4; i++)
            {
                cornerValue += sideLength - 1;
                if (cornerValue.IsPrime())
                {
                    primesCount++;
                }
            }

            diagonalCount += 4;
        } while ((double)primesCount / diagonalCount > 0.1D);
        
        return sideLength.ToString();
    }

    public string Md5OfSolution => "b62fc92a2561538525c89be63f36bf7b";
}