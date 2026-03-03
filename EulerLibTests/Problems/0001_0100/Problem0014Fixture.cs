using EulerLib.Problems;

namespace EulerLibTests.Problems
{
    public class Problem0014Fixture
    {
        [Theory]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(50)]
        public void CollatzChainTerms_EntryForEachIntegerAboveTwo(int maximumStartingNumber)
        {
            // Arrange
            var sut = new Problem0014();

            // Act
            var terms = sut.CollatzChainTerms(maximumStartingNumber);

            // Assert
            terms.Count.Should().Be(maximumStartingNumber - 1);
        }

        [Theory]
        [InlineData(13,10)]
        public void CollatzChainTerms_ContainsExpectedResults(int startingNumber, int expectedTerms)
        {
            // Arrange
            var sut = new Problem0014();

            // Act
            var terms = sut.CollatzChainTerms(startingNumber);

            // Assert
            terms[startingNumber].Should().Be(expectedTerms);
        }
    
    }
}