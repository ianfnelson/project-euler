namespace EulerLib.Problems;

public class Problem0052 : IProblem
{
    public int Id => 52;
    public string Title => "Permuted Multiples";
    public string Solve()
    {
        var x = 1;

        while (!MeetsCriteria(x))
        {
            x++;
        }
        
        return x.ToString();
    }

    private static bool MeetsCriteria(int i)
    {
        var originalOrdered = OrderedInteger(i);

        for (var j = 2; j <= 6; j++)
        {
            if (OrderedInteger(i * j) != originalOrdered)
            {
                return false;
            }
        }

        return true;
    }

    public string Md5OfSolution => "a420384997c8a1a93d5a84046117c2aa";

    private static string OrderedInteger(int number)
    {
        return string.Concat(number.ToString().ToCharArray().OrderBy(x => x));
    }
}