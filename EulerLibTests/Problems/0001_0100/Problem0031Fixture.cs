using EulerLib.Problems;

namespace EulerLibTests.Problems;

public class Problem0031Fixture
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    [InlineData(5, 4)]
    [InlineData(10, 11)]
    public void WaysOfMakingTests(int n, int expectedWays)
    {
        var sut = new Problem0031();

        var ways = Problem0031.WaysOfMaking(n);

        ways.Should().Be(expectedWays);
    }
}