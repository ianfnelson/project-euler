using EulerLib.Problems;
using FluentAssertions;
using NUnit.Framework;

namespace EulerLibTests.Problems
{
    [TestFixture]
    public class Problem0007Fixture
    {
        [Test]
        public void PrimeInPosition6Is13()
        {
            var sut = new Problem0007();

            var result = sut.PrimeInPosition(6);

            result.Should().Be(13);
        }
    }
}