namespace EulerLib.Problems;

public class Problem0079 : IProblem
{
    public int Id => 79;
    public string Title => "Passcode derivation";
    
    private static readonly Dictionary<char, HashSet<char>> CharactersAfter = new();
    public string Solve()
    {
        PopulateCharactersAfter();

        return new string(GetSequenceFromEnd().Reverse().ToArray());
    }

    private IEnumerable<char> GetSequenceFromEnd()
    {
        HashSet<char> characters = new();

        foreach (var t in CharactersAfter)
        {
            var nextChar = CharactersAfter.First(ca => 
                !characters.Contains(ca.Key) &&
                ca.Value.All(c => characters.Contains(c))).Key;
            characters.Add(nextChar);
            yield return nextChar;
        }
    }

    private void PopulateCharactersAfter()
    {
        foreach (var line in File.ReadLines("ContentFiles/problem0079.txt"))
        {
            var chars = line.ToCharArray();
            
            PopulateCharactersAfter(chars[0], chars[1]);
            PopulateCharactersAfter(chars[0], chars[2]);
            PopulateCharactersAfter(chars[1], chars[2]);
        }
    }

    private void PopulateCharactersAfter(char cBefore, char cAfter)
    {
        if (!CharactersAfter.ContainsKey(cBefore))
        {
            CharactersAfter.Add(cBefore, []);
        }
        if (!CharactersAfter.ContainsKey(cAfter))
        {
            CharactersAfter.Add(cAfter, []);
        }
        
        CharactersAfter[cBefore].Add(cAfter);
    }

    public string Md5OfSolution => "3ccc6e16d99b21d42948f6d49b90fa30";
}