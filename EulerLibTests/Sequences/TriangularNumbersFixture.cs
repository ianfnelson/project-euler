using EulerLib.Sequences;

namespace EulerLibTests.Sequences;

public class TriangularNumbersFixture
{
    [Fact]
    public void TriangularNumbers_GenerateToMaximumSize()
    {
        var sequence = new TriangularNumbers().GenerateToMaximumSize(10);

        sequence.Should().BeEquivalentTo(new[] { 1, 3, 6, 10, 15, 21, 28, 36, 45, 55 });
    }

    [Fact]
    public void TriangularNumbers_GenerateToMaximumValue()
    {
        var sequence = new TriangularNumbers().GenerateToMaximumValue(22);

        sequence.Should().BeEquivalentTo(new[] { 1, 3, 6, 10, 15, 21 });
    }
}