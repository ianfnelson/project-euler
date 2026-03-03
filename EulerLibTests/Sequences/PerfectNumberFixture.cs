using EulerLib.Sequences;

namespace EulerLibTests.Sequences;

public class PerfectNumbersFixture
{
    [Theory]
    [InlineData(0, 6)]
    [InlineData(1, 28)]
    public void AbundantsTestCases(int index, int value)
    {
        var sequence = new PerfectNumbers().GenerateToMaximumSize(2);

        sequence.ElementAt(index).Should().Be(value);
    }
}