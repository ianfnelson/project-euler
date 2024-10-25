using EulerLib.Sequences;

namespace EulerLibTests.Sequences;

[TestFixture]
public class SquareNumbersFixture
{
    [Test]
    public void SquareNumbers_GenerateToMaximumSize()
    {
        var sequence = new SquareNumbers().GenerateToMaximumSize(10);

        sequence.Should().BeEquivalentTo([1, 4, 9, 16, 25, 36, 49, 64, 81, 100]);
    }

    [Test]
    public void PentagonalNumbers_GenerateToMaximumValue()
    {
        var sequence = new SquareNumbers().GenerateToMaximumValue(80);

        sequence.Should().BeEquivalentTo([1, 4, 9, 16, 25, 36, 49, 64]);
    }
}