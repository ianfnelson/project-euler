namespace EulerLib.Problems;

public class Problem0026 : IProblem
{
    public int Id => 26;

    public string Title => "Reciprocal Cycles";

    public string Solve()
    {
        return DenominatorWIthMaximumReciprocalCycleLength(1000).ToString();
    }

    public string Md5OfSolution => "6aab1270668d8cac7cef2566a1c5f569";

    public static int DenominatorWIthMaximumReciprocalCycleLength(int maximumDenominator)
    {
        var maxCycleLength = 0;
        var denominatorOfMaxCycleLength = 0;

        for (var denominator = maximumDenominator; denominator > 0; denominator--)
        {
            if (maxCycleLength > denominator) break;

            var cycleLength = ReciprocalCycleLength(denominator);

            if (cycleLength > maxCycleLength)
            {
                maxCycleLength = cycleLength;
                denominatorOfMaxCycleLength = denominator;
            }
        }

        return denominatorOfMaxCycleLength;
    }

    public static int ReciprocalCycleLength(int denominator)
    {
        var value = 1;
        var position = 0;

        var remainderPositions = new Dictionary<int, int>();

        while (value != 0 && !remainderPositions.ContainsKey(value))
        {
            remainderPositions.Add(value, position);
            value *= 10;
            value %= denominator;
            position++;
        }

        if (value == 0) return 0;

        return position - remainderPositions[value];
    }
}