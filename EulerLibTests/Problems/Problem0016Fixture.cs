using EulerLib.Problems;

namespace EulerLibTests.Problems;

[TestFixture]
public class Problem0016Fixture
{
    [TestCase(3, 2,9)]
    [TestCase(4,3,10)]
    [TestCase(2,15,26)]
    public void PowerDigitSumTests(int value, int exponent, int expectedSum)
    {
        var sut = new Problem0016();

        var sum = sut.PowerDigitSum(value, exponent);

        sum.Should().Be(expectedSum);
    }
}