using EulerLib.Sequences;

namespace EulerLibTests.Sequences;

public class FibonacciNumbersFixture
{
    [Fact]
    public void FibonacciTest_GenerateToMaximumSize()
    {
        var sequence = new FibonacciNumbers().GenerateToMaximumSize(10);

        sequence.Should().BeEquivalentTo(new[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 });
    }

    [Fact]
    public void FibonacciTest_GenerateToMaximumValue()
    {
        var sequence = new FibonacciNumbers().GenerateToMaximumValue(50);

        sequence.Should().BeEquivalentTo(new[] { 1, 2, 3, 5, 8, 13, 21, 34});
    }
}