using System.Collections.Generic;
using System.Linq;

namespace EulerLib.Problems
{
    public class Problem0014 : IProblem
    {
        public int Id
        {
            get { return 14; }
        }

        public string Title
        {
            get { return "Longest Collatz sequence"; }
        }

        public string Solve()
        {
            var terms = CollatzChainTerms(1000000);
            var maxValue = terms.Values.Max();

            return terms.FirstOrDefault(x => x.Value == maxValue).Key.ToString();
        }

        public string Md5OfSolution
        {
            get { return "5052c3765262bb2c6be537abd60b305e"; }
        }

        public IDictionary<long, int> CollatzChainTerms(int maximumStartingNumber)
        {
            var dictionary = new Dictionary<long, int>();

            for (var i = 2; i <= maximumStartingNumber; i++)
            {
                var termCount = 1;
                var term = (long)i;

                do
                {
                    if (dictionary.ContainsKey(term))
                    {
                        termCount += dictionary[term]-1;
                        term = 1;
                    }
                    else if (term%2 == 0)
                    {
                        termCount++;
                        term = term/2;
                    }
                    else
                    {
                        termCount ++;
                        term = (3*term) + 1;
                    }
                } while (term != 1);

                dictionary.Add(i, termCount);
            }

            return dictionary;
        }
    }
}