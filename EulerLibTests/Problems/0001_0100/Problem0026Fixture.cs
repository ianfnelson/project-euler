using EulerLib.Problems;

namespace EulerLibTests.Problems;

public class Problem0026Fixture
{
    [Theory]
    [InlineData(2, 0)]
    [InlineData(3, 1)]
    [InlineData(4, 0)]
    [InlineData(5, 0)]
    [InlineData(6, 1)]
    [InlineData(7, 6)]
    [InlineData(8, 0)]
    [InlineData(9, 1)]
    [InlineData(10, 0)]
    public void ReciprocalCycleLength_Tests(int denominator, int expectedCycleLength)
    {
        var cycleLength = Problem0026.ReciprocalCycleLength(denominator);

        cycleLength.Should().Be(expectedCycleLength);
    }

    [Theory]
    [InlineData(4, 3)]
    [InlineData(10, 7)]
    public void MaximumReciprocalCycleLengthTest(int maximumDenomator, int expectedMaximumCycleLength)
    {
        var cycleLength = Problem0026.DenominatorWIthMaximumReciprocalCycleLength(maximumDenomator);

        cycleLength.Should().Be(expectedMaximumCycleLength);
    }
}