using EulerLib.Problems;

namespace EulerLibTests.Problems;

public class Problem0002Fixture
{
    [Fact]
    public void SumEvenFibonacciWithValuesNotExceeding89Is44()
    {
        var sut = new Problem0002();

        var result = Problem0002.SumEvenFibonacciWithValuesNotExceeding(89);

        result.Should().Be(44);
    }
}