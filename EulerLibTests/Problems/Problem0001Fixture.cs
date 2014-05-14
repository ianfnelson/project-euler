using EulerLib.Problems;
using FluentAssertions;
using NUnit.Framework;

namespace EulerLibTests.Problems
{
    [TestFixture]
    public class Problem0001Fixture
    {
        [Test]
        public void SumMultiplesOfThreeAndFiveBelowTenIs23()
        {
            var sut = new Problem0001();

            var result = sut.SumMultiplesOfThreeAndFiveBelow(10);

            result.Should().Be(23);
        }
    }
}