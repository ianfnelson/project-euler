using EulerLib.Sequences;
using FluentAssertions;
using NUnit.Framework;

namespace EulerLibTests.Sequences
{
    [TestFixture]
    public class FibonacciNumbersFixture
    {
        [Test]
        public void FibonaaciTest_GenerateToMaximumSize()
        {
            var sequence = new FibonacciNumbers().GenerateToMaximumSize(10);

            sequence.ShouldAllBeEquivalentTo(new[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 });
        }

        [Test]
        public void FibonaaciTest_GenerateToMaximumValue()
        {
            var sequence = new FibonacciNumbers().GenerateToMaximumValue(50);

            sequence.ShouldAllBeEquivalentTo(new[] { 1, 2, 3, 5, 8, 13, 21, 34});
        }
    }
}