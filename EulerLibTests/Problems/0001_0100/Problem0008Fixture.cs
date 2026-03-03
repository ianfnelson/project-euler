using EulerLib.Problems;

namespace EulerLibTests.Problems;

public class Problem0008Fixture
{
    [Theory]
    [InlineData("123", 1, 3)]
    [InlineData("123", 2, 6)]
    [InlineData("123459", 2, 45)]
    [InlineData("593451", 3, 135)]
    public void LargestProductOfDigitsTests(string text, int digits, int expectedResult)
    {
        var sut = new Problem0008();

        var result = sut.LargestProductOfDigits(text, digits);

        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("7", 7)]
    [InlineData("123", 6)]
    [InlineData("123459", 1080)]
    [InlineData("593451", 2700)]
    public void ProductOfDigitsTests(string text, int expectedResult)
    {
        var sut = new Problem0008();

        var result = sut.ProductOfDigits(text);

        result.Should().Be(expectedResult);
    }
}