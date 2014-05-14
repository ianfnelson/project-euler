using System;
using EulerLib.IntegerExtensions;

namespace EulerLib.Sequences
{
    public class DeficientNumbers
        : NaiveSequenceGeneratorBase
    {
        public override bool IntegerIsMemberOfSequence(int n)
        {
            return n.IsDeficient();
        }
    }
}
