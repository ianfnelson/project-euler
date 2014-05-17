using EulerLib.IntegerExtensions;

namespace EulerLib.Sequences
{
    public class PerfectNumbers : NaiveSequenceGeneratorBase
    {
        public override bool IntegerIsMemberOfSequence(long n)
        {
            return n.IsPerfect();
        }
    }
}