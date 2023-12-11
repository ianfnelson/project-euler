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
                .Select(x => AlphabeticalValues[x])
                .Sum();

            total += nameValue * position;
        }

        return total.ToString();
    }

    public string Md5OfSolution => "f2c9c91cb025746f781fa4db8be3983f";

    private static readonly Dictionary<char, int> AlphabeticalValues = new()
    {
        { 'A', 1 },
        { 'B', 2 },
        { 'C', 3 },
        { 'D', 4 },
        { 'E', 5 },
        { 'F', 6 },
        { 'G', 7 },
        { 'H', 8 },
        { 'I', 9 },
        { 'J', 10 },
        { 'K', 11 },
        { 'L', 12 },
        { 'M', 13 },
        { 'N', 14 },
        { 'O', 15 },
        { 'P', 16 },
        { 'Q', 17 },
        { 'R', 18 },
        { 'S', 19 },
        { 'T', 20 },
        { 'U', 21 },
        { 'V', 22 },
        { 'W', 23 },
        { 'X', 24 },
        { 'Y', 25 },
        { 'Z', 26 }
    };
}