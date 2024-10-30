using EulerLib.Problems;
using FluentAssertions;
using NUnit.Framework;

namespace EulerLibTests.Problems
{
    [TestFixture]
    public class Problem0015Fixture
    {
        [TestCase(2,6)]
        [TestCase(3, 20)]
        public void PathsThroughGridWithSideLength(int sideLength, long expectedPaths)
        {
            var sut = new Problem0015();

            var paths = sut.PathsThroughGridWithSideLength(sideLength);

            paths.Should().Be(expectedPaths);
        }
    }
}