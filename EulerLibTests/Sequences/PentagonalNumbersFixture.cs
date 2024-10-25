using EulerLib.Sequences;

namespace EulerLibTests.Sequences;

[TestFixture]
public class PentagonalNumbersFixture
{
    [Test]
    public void PentagonalNumbers_GenerateToMaximumSize()
    {
        var sequence = new PentagonalNumbers().GenerateToMaximumSize(10);

        sequence.Should().BeEquivalentTo([1, 5, 12, 22, 35, 51, 70, 92, 117, 145]);
    }

    [Test]
    public void PentagonalNumbers_GenerateToMaximumValue()
    {
        var sequence = new PentagonalNumbers().GenerateToMaximumValue(22);

        sequence.Should().BeEquivalentTo([1, 5, 12, 22]);
    }
}