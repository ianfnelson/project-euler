using EulerLib.Problems;

namespace EulerLibTests.Problems;

[TestFixture]
public class Problem0025Fixture
{
    [TestCase(3, 12)]
    public void IndexOfFirstFibonacciNumberToContainNDigitsTests(int n, int expectedIndex)
    {
        var sut = new Problem0025();

        var index = Problem0025.IndexOfFirstFibonacciNumberToContainNDigits(n);

        index.Should().Be(expectedIndex);
    }
}