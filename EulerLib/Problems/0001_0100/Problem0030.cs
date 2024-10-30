using EulerLib.Extensions;

namespace EulerLib.Problems;

public class Problem0030 : IProblem
{
    public int Id => 30;

    public string Title => "Digit Fifth Powers";

    public string Solve()
    {
        return SumOfNumbersThatCanBeBeWrittenAsSumOfNthPowerOfDigits(5).ToString();
    }

    public string Md5OfSolution => "27a1779a8a8c323a307ac8a70bc4489d";

    public static int SumOfNumbersThatCanBeBeWrittenAsSumOfNthPowerOfDigits(int n)
    {
        var maximum = n * (int)Math.Pow(9, n);

        var powerMap = Enumerable.Range(0, 10)
            .ToDictionary(digit => digit, digit => (int)Math.Pow(digit, n));

        var matches = new List<int>();

        for (var trial = 2; trial <= maximum; trial++)
        {
            var sumOfNthPowerOfDigits = trial.Digits().Sum(digit => powerMap[digit]);

            if (sumOfNthPowerOfDigits == trial) matches.Add(trial);
        }

        return matches.Sum();
    }
}