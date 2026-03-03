using EulerLib.Problems;

namespace EulerLibTests.Problems;

public class Problem0010Fixture
{
    [Fact]
    public void SumOfPrimesBelow10Is17()
    {
        var sut = new Problem0010();

        var result = sut.SumOfPrimesBelow(10);

        result.Should().Be(17);
    }
}