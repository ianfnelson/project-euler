namespace EulerLib.Problems;

public class Problem0019 : IProblem
{
    public int Id => 19;
    public string Title => "Counting Sundays";
    public string Solve()
    {
        var sundayCount = 0;
        for (var y = 1901; y <= 2000; y++)
        {
            for (var m = 1; m <= 12; m++)
            {
                if (new DateOnly(y, m, 1).DayOfWeek == DayOfWeek.Sunday)
                {
                    sundayCount++;
                }
            }
        }

        return sundayCount.ToString();
    }

    public string Md5OfSolution => "a4a042cf4fd6bfb47701cbc8a1653ada";
}