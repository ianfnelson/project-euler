using EulerLib.Problems;

namespace EulerLibTests.Problems;

[TestFixture]
public class Problem0008Fixture
{
    [TestCase("123", 1, 3)]
    [TestCase("123", 2, 6)]
    [TestCase("123459", 2, 45)]
    [TestCase("593451", 3, 135)]
    public void LargestProductOfDigitsTests(string text, int digits, int expectedResult)
    {
        var sut = new Problem0008();

        var result = sut.LargestProductOfDigits(text, digits);

        result.Should().Be(expectedResult);
    }

    [TestCase("7", 7)]
    [TestCase("123", 6)]
    [TestCase("123459", 1080)]
    [TestCase("593451", 2700)]
    public void ProductOfDigitsTests(string text, int expectedResult)
    {
        var sut = new Problem0008();

        var result = sut.ProductOfDigits(text);

        result.Should().Be(expectedResult);
    }
}