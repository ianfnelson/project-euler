﻿using System.Linq;

namespace EulerLib.Problems
{
    public class Problem0001 : IProblem
    {
        public int Id
        {
            get { return 1; }
        }

        public string Title
        {
            get { return "Multiples of 3 and 5"; }
        }

        public string Solve()
        {
            return SumMultiplesOfThreeAndFiveBelow(1000).ToString();
        }

        public string Md5OfSolution
        {
            get { return "e1edf9d1967ca96767dcc2b2d6df69f4"; }
        }

        public int SumMultiplesOfThreeAndFiveBelow(int ceiling)
        {
            return Enumerable.Range(1, ceiling - 1)
                             .Where(x => x%3 == 0 || x%5 == 0)
                             .Sum();
        }
    }
}