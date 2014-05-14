using System;
using System.Collections.Generic;

namespace EulerLib.Sequences
{
    public interface ISequenceGenerator<T>
    {
        IEnumerable<T> Generate();

        IEnumerable<T> GenerateToMaximumValue(int maximumValue);

        IEnumerable<T> GenerateToMaximumSize(int maximumSize);
    }
}
