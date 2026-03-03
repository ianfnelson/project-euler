using EulerLib.Extensions;

namespace EulerLibTests.Extensions;

public class StringExtensionsFixture
{
    [Theory]
    [InlineData("", "")]
    [InlineData("a", "a")]
    [InlineData("Ian Fraser Nelson", "nosleN resarF naI")]
    public void ReverseStringTestCases(string input, string expectedOutput)
    {
        input.ReverseString().Should().Be(expectedOutput);
    }
        
    [Theory]
    [InlineData("12321", true)]
    [InlineData("1", true)]
    [InlineData("333", true)]
    [InlineData("4567887654", true)]
    [InlineData("12", false)]
    [InlineData("345432", false)]
    public void IsPalindromicTestCases(string input, bool expectedIsPalindromic)
    {
        input.IsPalindromic().Should().Be(expectedIsPalindromic);
    }
}