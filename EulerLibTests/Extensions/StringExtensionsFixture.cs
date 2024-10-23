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
    }
}