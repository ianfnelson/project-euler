namespace EulerLib.Problems;

public class Problem0028 : IProblem
{
    public int Id => 28;
    public string Title => "Number Spiral Diagonals";
    public string Solve()
    {
        return SumOfDiagonals(1001).ToString();
    }

    public string Md5OfSolution => "0d53425bd7c5bf9919df3718c8e49fa6";

    public static int SumOfDiagonals(int numberSpiralSize)
    {
        var sum = 1;
        for (var i = 3; i <= numberSpiralSize; i += 2)
        {
            sum += (4 * (i * i) - (6 * (i - 1)));
        }

        return sum;
    }
}