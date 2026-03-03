using EulerLib.Problems;

namespace EulerLibTests.Problems;

public class Problem0003Fixture
{
    [Fact]
    public void LargestPrimeFactorOf13195Is29()
    {
        var sut = new Problem0003();

        var result = sut.LargestPrimeFactorOf(13195);

        result.Should().Be(29);
    }
}