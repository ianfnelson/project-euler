using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerLib.Sequences
{
    public abstract class NaiveSequenceGeneratorBase : SequenceGeneratorBase
    {
        public abstract bool IntegerIsMemberOfSequence(int n);

        public override IEnumerable<int> Generate()
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
