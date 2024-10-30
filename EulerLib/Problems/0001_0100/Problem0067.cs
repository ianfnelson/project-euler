namespace EulerLib.Problems;

public class Problem0067 : IProblem
{
    public int Id => 67;

    public string Title => "Maximum path sum II";

    public string Solve()
    {
        var filePath = "ContentFiles/problem0067.txt";

        var problem18 = new Problem0018();
        return Problem0018.MaximumPathThroughTriangle(filePath).ToString();
    }

    public string Md5OfSolution => "9d702ffd99ad9c70ac37e506facc8c38";
}