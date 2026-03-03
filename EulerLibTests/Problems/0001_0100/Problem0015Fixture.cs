using EulerLib.Problems;

namespace EulerLibTests.Problems
{
    public class Problem0015Fixture
    {
        [Theory]
        [InlineData(2,6)]
        [InlineData(3, 20)]
        public void PathsThroughGridWithSideLength(int sideLength, long expectedPaths)
        {
            var sut = new Problem0015();

            var paths = sut.PathsThroughGridWithSideLength(sideLength);

            paths.Should().Be(expectedPaths);
        }
    }
}