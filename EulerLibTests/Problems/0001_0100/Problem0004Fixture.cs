using EulerLib.Problems;

namespace EulerLibTests.Problems;

[TestFixture]
public class Problem0004Fixture
{
    [TestCase(0)]
    [TestCase(-1)]
    [TestCase(int.MinValue)]
    public void LargestPalindromeMadeFromProductOfTwoIntegersThrowsIfDigitsIsLessThan1(int digits)
    {
        var sut = new Problem0004();
        var ex =
            Assert.Throws<ArgumentOutOfRangeException>(
                () => Problem0004.LargestPalindromeMadeFromProductOfTwoIntegersWithDigits(digits));

        ex.Message.Should().Contain("digits must be 1 or more");
        ex.ParamName.Should().Be("digits");
    }

    [Test]
    public void LargestPalindromeMadeFromProductOfTwoIntegersWithDigits2Is9009()
    {
        var sut = new Problem0004();

        var result = Problem0004.LargestPalindromeMadeFromProductOfTwoIntegersWithDigits(2);

        result.Should().Be(9009);
    }
}