using EulerLib.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace EulerLibTests.Extensions
{
    [TestFixture]
    public class StringExtensionsFixture
    {
        [TestCase(null, null)]
        [TestCase("", "")]
        [TestCase("a", "a")]
        [TestCase("Ian Fraser Nelson", "nosleN resarF naI")]
        public void ReverseStringTestCases(string input, string expectedOutput)
        {
            input.ReverseString().Should().Be(expectedOutput);
        }
    }
}