using EulerLib.Sequences;

namespace EulerLibTests.Sequences;

[TestFixture]
public class HexagonalNumbersFixture
{
    [Test]
    public void HexagonalNumbers_GenerateToMaximumSize()
    {
        var sequence = new HexagonalNumbers().GenerateToMaximumSize(5);

        sequence.Should().BeEquivalentTo([1, 6, 15, 28, 45]);
    }

    [Test]
    public void HexagonalNumbers_GenerateToMaximumValue()
    {
        var sequence = new HexagonalNumbers().GenerateToMaximumValue(40);

        sequence.Should().BeEquivalentTo([1, 6, 15, 28]);
    }
}