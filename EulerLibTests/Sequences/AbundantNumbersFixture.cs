using System;
using System.Linq;
using EulerLib.Sequences;
using NUnit.Framework;

namespace EulerLibTests.Sequences
{
    [TestFixture]
    public class AbundantNumbersFixture
    {
        [TestCase(0, 12)]
        [TestCase(1, 18)]
        [TestCase(2, 20)]
        [TestCase(3, 24)]
        [TestCase(4, 30)]
        public void AbundantsTestCases(int index, int value)
        {
            var sequence = new AbundantNumbers().GenerateToMaximumSize(5);

            Assert.That(sequence.ElementAt(index), Is.EqualTo(value));
        }
    }
}