using EulerLib.Problems;

namespace EulerLibTests.Problems
{
    [TestFixture]
    public class Problem0030Fixture
    {
        [TestCase(4,19316)]
        public void SumOfNumbersThatCanBeWrittenAsSumOfNthPower_Tests(int n, int expectedSum)
        {
            var sum = Problem0030.SumOfNumbersThatCanBeBeWrittenAsSumOfNthPowerOfDigits(4);
        
            sum.Should().Be(expectedSum);
        }
    }
}