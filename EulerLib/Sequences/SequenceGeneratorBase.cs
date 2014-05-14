using System.Collections.Generic;
using System.Linq;

namespace EulerLib.Sequences
{
    public abstract class SequenceGeneratorBase : ISequenceGenerator<int>
    {
        public abstract IEnumerable<int> Generate();

        public IEnumerable<int> GenerateToMaximumValue(int maximumValue)
        {
            return Generate().TakeWhile(value => value <= maximumValue);
        }

        public IEnumerable<int> GenerateToMaximumSize(int maximumSize)
        {
            var x = 0;

            foreach (var value in Generate())
            {
                x++;
                if (x > maximumSize) break;
                yield return value;
            }
        }
    }
}