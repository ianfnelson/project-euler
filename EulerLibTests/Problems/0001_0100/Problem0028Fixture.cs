using EulerLib.Problems;

namespace EulerLibTests.Problems;

[TestFixture]
public class Problem0028Fixture
{
    [TestCase(1, 1)]
    [TestCase(3, 25)]
    [TestCase(5, 101)]
    public void SumOfDiagonals_Tests(int numberSpiralSize, int expectedSumOfDiagonals)
    {
        var sumOfDiagonals = Problem0028.SumOfDiagonals(numberSpiralSize);

        sumOfDiagonals.Should().Be(expectedSumOfDiagonals);
    }
}