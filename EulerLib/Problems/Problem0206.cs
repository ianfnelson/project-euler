using System.Text.RegularExpressions;

namespace EulerLib.Problems;

public class Problem0206 : IProblem
{
    public int Id => 206;
    public string Title => "Concealed square";
    public string Solve()
    {
        var value = 1010101030L;
        
        var sought = new Regex(@"1\d2\d3\d4\d5\d6\d7\d8\d9\d");

        do
        {
            if (value % 100L == 30L || value % 100L == 70L)
            {
                long square = value * value;
                if (sought.IsMatch(square.ToString()))
                {
                    return value.ToString();
                }
            }

            value+=10;
        } while (true);
    }

    public string Md5OfSolution { get; }
}