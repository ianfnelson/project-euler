using EulerLib.Problems;

namespace EulerLibTests.Problems;

public class Problem0092Fixture
{
    [Theory]
    [InlineData(85, 89)]
    [InlineData(89, 145)]
    [InlineData(145, 42)]
    [InlineData(42, 20)]
    [InlineData(20, 4)]
    public void SumOfSquareOfDigitsTest(int number, int expectedSumOfSquareOfDigits)
    {
        Problem0092.SumOfSquareOfDigits(number).Should().Be(expectedSumOfSquareOfDigits);
    }

    [Theory]
    [InlineData(44, 1)]
    [InlineData(32, 1)]
    [InlineData(10, 1)]
    [InlineData(1, 1)]
    [InlineData(89, 89)]
    [InlineData(85, 89)]
    [InlineData(145, 89)]
    public void EndValue(int number, int expectedEndValue)
    {
        var sut = new Problem0092();
        
        Problem0092.EndValue(number).Should().Be(expectedEndValue);
    }
}