using EulerLib.Problems;
using FluentAssertions;
using NUnit.Framework;

namespace EulerLibTests.Problems
{
    [TestFixture]
    public class Problem0031Fixture
    {
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 4)]
        [TestCase(10, 11)]
        public void WaysOfMakingTests(int n, int expectedWays)
        {
            var sut = new Problem0031();

            var ways = Problem0031.WaysOfMaking(n);

            ways.Should().Be(expectedWays);
        }
    }
}