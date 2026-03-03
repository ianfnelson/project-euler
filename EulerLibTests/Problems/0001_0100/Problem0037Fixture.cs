using EulerLib.Problems;

namespace EulerLibTests.Problems;

public class Problem0037Fixture
{
    [Fact]
    public void GetTruncatedValuesTest()
    {
        var list = Problem0037.GetTruncatedValues(3797).ToList();

        list.Count.Should().Be(6);
        list.Sum().Should().Be(1320);
    }
}