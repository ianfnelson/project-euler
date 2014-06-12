using System.Collections.Generic;

namespace EulerLib.Problems
{
    public class Problem0026 : IProblem
    {
        public int Id
        {
            get { return 26; }
        }

        public string Title
        {
            get { return "Reciprocal Cycles"; }
        }

        public string Solve()
        {
            return DenominatorWIthMaximumReciprocalCycleLength(1000).ToString();
        }

        public int DenominatorWIthMaximumReciprocalCycleLength(int maximumDenominator)
        {
            int maxCycleLength = 0;
            int denominatorOfMaxCycleLength = 0;

            for (int denominator = maximumDenominator; denominator > 0; denominator--)
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

        public int ReciprocalCycleLength(int denominator)
        {
            int value = 1;
            int position = 0;

            var remainderPositions = new Dictionary<int, int>();

            while (value !=0 && !remainderPositions.ContainsKey(value))
            {
                remainderPositions.Add(value, position);
                value *= 10;
                value %= denominator;
                position++;
            }

            if (value == 0) return 0;

            return position - remainderPositions[value];
        }

        public string Md5OfSolution
        {
            get { return "6aab1270668d8cac7cef2566a1c5f569"; }
        }
    }
}