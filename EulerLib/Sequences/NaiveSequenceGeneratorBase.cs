using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerLib.Sequences
{
    public abstract class NaiveSequenceGeneratorBase : ISequenceGenerator<int>
    {
        public abstract bool IntegerIsMemberOfSequence(int n);

        public IEnumerable<int> Generate()
        {
            var n = 1;

            do
            {
                if (IntegerIsMemberOfSequence(n)) yield return n;
                n++;
            } while (true);
        }

        public IEnumerable<int> GenerateToMaximumValue(int maximumValue)
        {
            return Generate().TakeWhile(value => value <= maximumValue);
        }

        public IEnumerable<int> GenerateToMaximumSize(int maximumSize)
        {
            var x = 0;

            foreach(var value in Generate())
            {
                x++;
                if (x > maximumSize) break;
                yield return value;
            }
        }
    }
}
