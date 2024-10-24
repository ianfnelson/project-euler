namespace EulerLib.Problems;

public class Problem0022 : IProblem
{
    public int Id => 22;
    public string Title => "Names Scores";
    public string Solve()
    {
        var names = File
            .ReadAllLines("ContentFiles/problem0022.txt")[0]
            .Split(",")
            .Select(x=> x.Substring(1, x.Length-2))
            .OrderBy(x => x)
            .ToList();

        var total = 0;

        for (var position = 1; position <= names.Count; position++)
        {
            var nameValue = names[position-1].ToCharArray()
                .Select(AlphabeticalPosition)
                .Sum();

            total += nameValue * position;
        }

        return total.ToString();
    }

    public string Md5OfSolution => "f2c9c91cb025746f781fa4db8be3983f";

    private static int AlphabeticalPosition(char capitalLetter)
    {
        return capitalLetter - 'A' + 1;
    }
}