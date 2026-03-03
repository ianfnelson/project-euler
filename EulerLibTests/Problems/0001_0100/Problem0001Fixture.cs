using EulerLib.Problems;
using FluentAssertions;

namespace EulerLibTests.Problems;

public class Problem0001Fixture
{
    [Fact]
    public void SumMultiplesOfThreeAndFiveBelowTenIs23()
    {
        var sut = new Problem0001();

        var result = Problem0001.SumMultiplesOfThreeAndFiveBelow(10);

        result.Should().Be(23);
    }
}