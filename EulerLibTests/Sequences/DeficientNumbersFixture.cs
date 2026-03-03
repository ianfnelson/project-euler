using EulerLib.Sequences;

namespace EulerLibTests.Sequences;

public class DeficientNumbersFixture
{
    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 2)]
    [InlineData(2, 3)]
    [InlineData(3, 4)]
    [InlineData(4, 5)]
    [InlineData(5, 7)]
    [InlineData(10, 13)]
    [InlineData(15, 19)]
    [InlineData(17, 22)]
    [InlineData(20, 26)]
    public void DeficientsTestCases(int index, int value)
    {
        var sequence = new DeficientNumbers().GenerateToMaximumSize(21);

        sequence.ElementAt(index).Should().Be(value);
    }
}