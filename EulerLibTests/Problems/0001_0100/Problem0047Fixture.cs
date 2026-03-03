using EulerLib.Problems;

namespace EulerLibTests.Problems
{
    public class Problem0047Fixture
    {
        [Theory]
        [InlineData(14, 2)]
        [InlineData(15, 2)]
        [InlineData(644, 3)]
        [InlineData(645, 3)]
        [InlineData(646, 3)]
        public void DistinctPrimeFactorCount(int x, int expectedValue)
        {
            var sut = new Problem0047();

            var actual = sut.DistinctPrimeFactors(x);

            actual.Should().Be(expectedValue);
        }

        [Theory]
        [InlineData(2, 14)]
        [InlineData(3, 644)]
        [InlineData(4, 134043)]
        public void FirstOfNConsecutiveIntegersWithNDistinctPrimeFactors(int n, int expectedValue)
        {
            var sut = new Problem0047();

            var actual = sut.FirstOfNConsecutiveIntegersWithNDistinctPrimeFactors(n);

            actual.Should().Be(expectedValue);
        }
    }
}
