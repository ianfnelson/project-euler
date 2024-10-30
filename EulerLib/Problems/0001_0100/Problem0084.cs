using EulerLib.Monopoly;

namespace EulerLib.Problems;

public class Problem0084 : IProblem
{
    public int Id => 84;
    public string Title => "Monopoly Odds";
    public string Solve()
    {
        var game = new Game(4);
        
        var frequencies = game.Simulate(20000000);

        var modalString =
            string.Concat(
                frequencies.OrderByDescending(kv => kv.Value)
                    .Take(3)
                    .Select(kv => kv.Key.ToString("D2"))
            );
        
        return modalString;
    }

    public string Md5OfSolution => "ead3264438ef83a8c2da2e98067b4445";
}