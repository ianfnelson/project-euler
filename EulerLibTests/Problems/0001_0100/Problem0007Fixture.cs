using EulerLib.Problems;

namespace EulerLibTests.Problems;

[TestFixture]
public class Problem0007Fixture
{
    [Test]
    public void PrimeInPosition6Is13()
    {
        var sut = new Problem0007();

        var result = Problem0007.PrimeInPosition(6);

        result.Should().Be(13);
    }
}