using EulerLib.Problems;

namespace EulerLibTests.Problems;

public class Problem0005Fixture
{
    [Fact]
    public void SmallestIntegerEvenlyDivisibleByNumbersFrom1To10Is2520()
    {
        var sut = new Problem0005();

        var result = sut.SmallestIntegerEvenlyDivisibleByNumbersFrom1To(10);

        result.Should().Be(2520);
    }
}