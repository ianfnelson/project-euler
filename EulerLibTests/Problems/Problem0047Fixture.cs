using EulerLib.Problems;
using FluentAssertions;
using NUnit.Framework;

namespace EulerLibTests.Problems
{
    [TestFixture]
    public class Problem0047Fixture
    {
        [TestCase(14, 2)]
        [TestCase(15, 2)]
        [TestCase(644, 3)]
        [TestCase(645, 3)]
        [TestCase(646, 3)]
        public void DistinctPrimeFactorCount(int x, int expectedValue)
        {
            var sut = new Problem0047();

            var actual = sut.DistinctPrimeFactors(x);

            actual.Should().Be(expectedValue);
        }

        [TestCase(2, 14)]
        [TestCase(3, 644)]
        [TestCase(4, 134043)]
        public void FirstOfNConsecutiveIntegersWithNDistinctPrimeFactors(int n, int expectedValue)
        {
            var sut = new Problem0047();

            var actual = sut.FirstOfNConsecutiveIntegersWithNDistinctPrimeFactors(n);

            actual.Should().Be(expectedValue);
        }
    }
}
