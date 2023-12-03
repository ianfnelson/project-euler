namespace EulerLib.Problems;

public class Problem0009 : IProblem
{
    public int Id => 9;

    public string Title => "Special Pythagorean triplet";

    public string Solve()
    {
        for (int a = 1; a < 999; a++)
        {
            for (int b = a; a + b < 1000; b++)
            {
                var potentialC = 1000 - a - b;

                if ((a * a) + (b * b) == (potentialC * potentialC))
                {
                    return (a * b * potentialC).ToString();
                }
            }
        }

        return "failed";
    }

    public string Md5OfSolution => "24eaa9820350012ff678de47cb85b639";
}