using EulerLib.Sequences;

namespace EulerLib.Problems;

public class Problem0042 : IProblem
{
    public int Id => 42;
    public string Title => "Coded Triangle Numbers";
    
    public string Solve()
    {
        var words = File
            .ReadAllLines("ContentFiles/problem0042.txt")[0]
            .Split(",")
            .Select(x=> x.Substring(1, x.Length-2))
            .OrderBy(x => x)
            .ToList();

        var upperBound = words.Max(w => w.Length) * 26;
        
        var triangularNumbers = new TriangularNumbers().GenerateToMaximumValue(upperBound).ToHashSet();

        return words
            .Count(x => triangularNumbers.Contains(WordValue(x)))
            .ToString();
    }

    private static int WordValue(string word)
    {
        return word.ToCharArray().Sum(AlphabeticalPosition);
    }

    private static int AlphabeticalPosition(char capitalLetter)
    {
        return capitalLetter - 'A' + 1;
    }

    public string Md5OfSolution => "82aa4b0af34c2313a562076992e50aa3";
}