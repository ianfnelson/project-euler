using EulerLib.Problems;

namespace EulerLibTests.Problems;

[TestFixture]
public class Problem0010Fixture
{
    [Test]
    public void SumOfPrimesBelow10Is17()
    {
        var sut = new Problem0010();

        var result = sut.SumOfPrimesBelow(10);

        result.Should().Be(17);
    }
}