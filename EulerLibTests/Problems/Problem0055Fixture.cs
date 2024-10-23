using EulerLib.Problems;

namespace EulerLibTests.Problems;

[TestFixture]
public class Problem0055Fixture
{
    [TestCase(3, false)]
    [TestCase(47, false)]
    [TestCase(349,false)]
    [TestCase(196,true)]
    [TestCase(4994, true)]
    public void IsLychrelTests(int n, bool expectedValue)
    {
        var actual = Problem0055.IsLychrel(n);

        actual.Should().Be(expectedValue);
    }
}