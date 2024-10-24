using EulerLib.Extensions;

namespace EulerLibTests.Extensions
{
    [TestFixture]
    public class StringExtensionsFixture
    {
        [TestCase("", "")]
        [TestCase("a", "a")]
        [TestCase("Ian Fraser Nelson", "nosleN resarF naI")]
        public void ReverseStringTestCases(string input, string expectedOutput)
        {
            input.ReverseString().Should().Be(expectedOutput);
        }
        
        [TestCase("12321", true)]
        [TestCase("1", true)]
        [TestCase("333", true)]
        [TestCase("4567887654", true)]
        [TestCase("12", false)]
        [TestCase("345432", false)]
        public void IsPalindromicTestCases(string input, bool expectedIsPalindromic)
        {
            input.IsPalindromic().Should().Be(expectedIsPalindromic);
        }
    }
}