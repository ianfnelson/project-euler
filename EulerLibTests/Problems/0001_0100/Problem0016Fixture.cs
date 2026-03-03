using EulerLib.Problems;

namespace EulerLibTests.Problems;

public class Problem0016Fixture
{
    [Theory]
    [InlineData(3, 2,9)]
    [InlineData(4,3,10)]
    [InlineData(2,15,26)]
    public void PowerDigitSumTests(int value, int exponent, int expectedSum)
    {
        var sut = new Problem0016();

        var sum = sut.PowerDigitSum(value, exponent);

        sum.Should().Be(expectedSum);
    }
}