using EulerLib.Sequences;

namespace EulerLib.Problems;

public class Problem0044 : IProblem
{
    public int Id => 44;
    public string Title => "Pentagon Numbers";
    public string Solve()
    {
        var pentagonalsList =
            new PentagonalNumbers()
                .GenerateToMaximumSize(5000)
                .Select(x => (int)x)
                .ToList();
        
        var pentagonalsHashset = pentagonalsList.ToHashSet();
        
        var minimalDifference = int.MaxValue;

        for (var j = 0; j < pentagonalsList.Count; j++)
        {
            for (var k = j + 1; k < pentagonalsList.Count; k++)
            {
                var pj = pentagonalsList[j];
                var pk = pentagonalsList[k];

                var diff = pk - pj;
                
                if (pentagonalsHashset.Contains(pj+pk) 
                    && pentagonalsHashset.Contains(diff)
                    && diff < minimalDifference)
                {
                    minimalDifference = diff; 
                }
            }
        }
        
        return minimalDifference.ToString();
    }

    public string Md5OfSolution => "2c2556cb85621309ca647465ffa62370";
}