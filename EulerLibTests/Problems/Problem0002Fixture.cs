using EulerLib.Problems;
using FluentAssertions;
using NUnit.Framework;

namespace EulerLibTests.Problems
{
    [TestFixture]
    public class Problem0002Fixture
    {
        [Test]
        public void SumEvenFibonacciWithValuesNotExceeding89Is44()
        {
            var sut = new Problem0002();

            var result = Problem0002.SumEvenFibonacciWithValuesNotExceeding(89);

            result.Should().Be(44);
        }
    }
}