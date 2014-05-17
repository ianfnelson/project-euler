using EulerLib.Problems;
using FluentAssertions;
using NUnit.Framework;

namespace EulerLibTests.Problems
{
    [TestFixture]
    public class Problem0006Fixture
    {
        [Test]
        public void SumOfSquaresOfFirst10NaturalsIs385()
        {
            var sut = new Problem0006();

            var result = sut.SumOfSquaresOfNaturalsTo(10);

            result.Should().Be(385);
        }

        [Test]
        public void SquareOfSumsOfFirst10NaturalsIs3025()
        {
            var sut = new Problem0006();

            var result = sut.SquareOfSumOfNaturalsTo(10);

            result.Should().Be(3025);
        }

        [Test]
        public void SumSquareDifferenceOfNaturalsUpTo10Is2640()
        {
            var sut = new Problem0006();

            var result = sut.SumSquareDifferenceOfNaturalsUpTo(10);

            result.Should().Be(2640);
        }
    }
}