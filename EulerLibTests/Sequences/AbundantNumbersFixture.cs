using EulerLib.Sequences;

namespace EulerLibTests.Sequences;

public class AbundantNumbersFixture
{
    [Theory]
    [InlineData(0, 12)]
    [InlineData(1, 18)]
    [InlineData(2, 20)]
    [InlineData(3, 24)]
    [InlineData(4, 30)]
    public void AbundantTestCases(int index, int value)
    {
        var sequence = new AbundantNumbers().GenerateToMaximumSize(index+1).ToList();

        sequence.Count.Should().Be(index+1);
        sequence[index].Should().Be(value);
    }

    [Fact]
    public void AbundantTestCases_UsingGenerateToMaximumValue()
    {
        var sequence = new AbundantNumbers().GenerateToMaximumValue(30);

        sequence.Should().BeEquivalentTo(new []{12,18,20,24,30});
    }
}