using System.Collections.Generic;

namespace EulerLib.Sequences
{
    public abstract class NaiveSequenceGeneratorBase : SequenceGeneratorBase
    {
        public abstract bool IntegerIsMemberOfSequence(long n);

        public override IEnumerable<long> Generate()
        {
            var n = 1;

            do
            {
                if (IntegerIsMemberOfSequence(n)) yield return n;
                n++;
            } while (true);
        }
    }
}