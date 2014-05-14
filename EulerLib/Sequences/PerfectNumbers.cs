using System;
using EulerLib.IntegerExtensions;

namespace EulerLib.Sequences
{
    public class PerfectNumbers : NaiveSequenceGeneratorBase
    {
        public override bool IntegerIsMemberOfSequence(int n)
        {
            return n.IsPerfect();
        }
    }
}