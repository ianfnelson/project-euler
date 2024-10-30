using EulerLib.Problems;
using FluentAssertions;
using NUnit.Framework;

namespace EulerLibTests.Problems
{
    [TestFixture]
    public class Problem0003Fixture
    {
        [Test]
        public void LargestPrimeFactorOf13195Is29()
        {
            var sut = new Problem0003();

            var result = sut.LargestPrimeFactorOf(13195);

            result.Should().Be(29);
        }
    }
}