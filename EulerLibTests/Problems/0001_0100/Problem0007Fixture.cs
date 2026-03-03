using EulerLib.Problems;

namespace EulerLibTests.Problems;

public class Problem0007Fixture
{
    [Fact]
    public void PrimeInPosition6Is13()
    {
        var sut = new Problem0007();

        var result = Problem0007.PrimeInPosition(6);

        result.Should().Be(13);
    }
}