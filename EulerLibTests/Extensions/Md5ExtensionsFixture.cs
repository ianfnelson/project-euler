using EulerLib.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace EulerLibTests.Extensions
{
    [TestFixture]
    public class Md5ExtensionsFixture
    {
        // 31626
        [TestCase("Hello World!", "ed076287532e86365e841e92bfc50d8c")]
        public void ToMd5Hash(string input, string expectedHash)
        {
            var hash = input.ToMd5Hash();

            hash.Should().Be(expectedHash);
        }

        [TestCase("Hello World!", "ed076287532e86365e841e92bfc50d8c", true)]
        [TestCase("Hello World!", "ed076287532e86355e841e92bfc50d8c", false)]
        public void VerifyMd5Hash(string input, string hash, bool expectedResult)
        {
            var result = input.VerifyMd5Hash(hash);

            result.Should().Be(expectedResult);
        }
    }
}