using EulerLib.Problems;
using FluentAssertions;
using NUnit.Framework;

namespace EulerLibTests.Problems
{
    [TestFixture]
    public class Problem0005Fixture
    {
        [Test]
        public void SmallestIntegerEvenlyDivisibleByNumbersFrom1To10Is2520()
        {
            var sut = new Problem0005();

            var result = sut.SmallestIntegerEvenlyDivisibleByNumbersFrom1To(10);

            result.Should().Be(2520);
        }
    }
}