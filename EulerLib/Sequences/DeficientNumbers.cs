﻿using EulerLib.Extensions;

namespace EulerLib.Sequences;

public class DeficientNumbers
    : NaiveSequenceGeneratorBase
{
    public override bool IntegerIsMemberOfSequence(long n)
    {
        return n.IsDeficient();
    }
}