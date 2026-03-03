using EulerLib.Problems;

namespace EulerLibTests.Problems;

public class Problem0030Fixture
{
    [Theory]
    [InlineData(4,19316)]
    public void SumOfNumbersThatCanBeWrittenAsSumOfNthPower_Tests(int n, int expectedSum)
    {
        var sum = Problem0030.SumOfNumbersThatCanBeBeWrittenAsSumOfNthPowerOfDigits(4);
        
        sum.Should().Be(expectedSum);
    }
}