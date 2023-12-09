using EulerLib.Extensions;

namespace EulerLib.Sequences;

public class PerfectNumbers : NaiveSequenceGeneratorBase
{
    public override bool IntegerIsMemberOfSequence(long n)
    {
        return n.IsPerfect();
    }
}