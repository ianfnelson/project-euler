using EulerLib.Extensions;

namespace EulerLib.Sequences
{
    public class AbundantNumbers : NaiveSequenceGeneratorBase
    {
        public override bool IntegerIsMemberOfSequence(long n)
        {
            return n.IsAbundant();
        }
    }
}