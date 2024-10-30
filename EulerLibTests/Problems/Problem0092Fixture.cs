using EulerLib.Problems;

namespace EulerLibTests.Problems;

[TestFixture]
public class Problem0092Fixture
{
    [TestCase(85, 89)]
    [TestCase(89, 145)]
    [TestCase(145, 42)]
    [TestCase(42, 20)]
    [TestCase(20, 4)]
    public void SumOfSquareOfDigitsTest(int number, int expectedSumOfSquareOfDigits)
    {
        Problem0092.SumOfSquareOfDigits(number).Should().Be(expectedSumOfSquareOfDigits);
    }

    [TestCase(44, 1)]
    [TestCase(32, 1)]
    [TestCase(10, 1)]
    [TestCase(1, 1)]
    [TestCase(89, 89)]
    [TestCase(85, 89)]
    [TestCase(145, 89)]
    public void EndValue(int number, int expectedEndValue)
    {
        var sut = new Problem0092();
        
        Problem0092.EndValue(number).Should().Be(expectedEndValue);
    }
}