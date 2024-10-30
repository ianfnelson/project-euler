using System.Text;

namespace EulerLib.Problems;

public class Problem0038 : IProblem
{
    public int Id => 38;
    public string Title => "Pandigital Multiples";
    public string Solve()
    {
        var winner = 0;
        
        for (var starter = 1; starter < 25000; starter++)
        {
            var sb = new StringBuilder();
            var multiplier = 0;

            while (sb.Length <= 9)
            {
                multiplier++;
                sb.Append(starter * multiplier);

                if (Is1To9Pandigital(sb.ToString()))
                {
                    var pandigital = int.Parse(sb.ToString());
                    if (pandigital > winner)
                    {
                        winner = pandigital;
                    }

                    break;
                }
            }
        }

        return winner.ToString();
    }

    private static bool Is1To9Pandigital(string number)
    {
        return number.Length == 9 &&
               !number.Contains('0') &&
               number.ToCharArray().Distinct().Count() == 9;
    }

    public string Md5OfSolution => "f2a29ede8dc9fae7926dc7a4357ac25e";
}