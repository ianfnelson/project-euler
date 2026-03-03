using EulerLib.Problems;

namespace EulerLibTests.Problems;

public class Problem0028Fixture
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(3, 25)]
    [InlineData(5, 101)]
    public void SumOfDiagonals_Tests(int numberSpiralSize, int expectedSumOfDiagonals)
    {
        var sumOfDiagonals = Problem0028.SumOfDiagonals(numberSpiralSize);

        sumOfDiagonals.Should().Be(expectedSumOfDiagonals);
    }
}