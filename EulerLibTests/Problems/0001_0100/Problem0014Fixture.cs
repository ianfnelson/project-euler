using EulerLib.Problems;

namespace EulerLibTests.Problems
{
    [TestFixture]
    public class Problem0014Fixture
    {
        [TestCase(2)]
        [TestCase(5)]
        [TestCase(50)]
        public void CollatzChainTerms_EntryForEachIntegerAboveTwo(int maximumStartingNumber)
        {
            // Arrange
            var sut = new Problem0014();

            // Act
            var terms = sut.CollatzChainTerms(maximumStartingNumber);

            // Assert
            terms.Count.Should().Be(maximumStartingNumber - 1);
        }

        [TestCase(13,10)]
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