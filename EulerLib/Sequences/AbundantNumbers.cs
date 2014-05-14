using System;
using EulerLib.IntegerExtensions;

namespace EulerLib.Sequences
{
    public class AbundantNumbers : NaiveSequenceGeneratorBase
    {
        public override bool IntegerIsMemberOfSequence(int n)
        {
            return n.IsAbundant();
        }
    }
}