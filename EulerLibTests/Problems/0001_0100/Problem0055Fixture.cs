using EulerLib.Problems;

namespace EulerLibTests.Problems;

public class Problem0055Fixture
{
    [Theory]
    [InlineData(3, false)]
    [InlineData(47, false)]
    [InlineData(349,false)]
    [InlineData(196,true)]
    [InlineData(4994, true)]
    public void IsLychrelTests(int n, bool expectedValue)
    {
        var actual = Problem0055.IsLychrel(n);

        actual.Should().Be(expectedValue);
    }
}