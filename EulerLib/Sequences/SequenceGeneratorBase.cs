using System.Collections.Generic;
using System.Linq;

namespace EulerLib.Sequences
{
    public abstract class SequenceGeneratorBase : ISequenceGenerator<long>
    {
        public abstract IEnumerable<long> Generate();

        public IEnumerable<long> GenerateToMaximumValue(long maximumValue)
        {
            return Generate().TakeWhile(value => value <= maximumValue);
        }

        public IEnumerable<long> GenerateToMaximumValue(int maximumValue)
        {
            return GenerateToMaximumValue((long) maximumValue);
        }

        public IEnumerable<long> GenerateToMaximumSize(long maximumSize)
        {
            var x = 0;

            foreach (var value in Generate())
            {
                x++;
                if (x > maximumSize) break;
                yield return value;
            }
        }

        public IEnumerable<long> GenerateToMaximumSize(int maximumSize)
        {
            return GenerateToMaximumSize((long)maximumSize);
        }
    }
}