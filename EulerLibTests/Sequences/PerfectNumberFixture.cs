using System;
using System.Linq;
using EulerLib.Sequences;
using NUnit.Framework;

namespace EulerLibTests.Sequences
{
    [TestFixture]
    public class PerfectNumbersFixture
    {
        [TestCase(0, 6)]
        [TestCase(1, 28)]
        public void AbundantsTestCases(int index, int value)
        {
            var sequence = new PerfectNumbers().GenerateToMaximumSize(2);

            Assert.That(sequence.ElementAt(index), Is.EqualTo(value));
        }
    }
}