using EulerLib.Sequences;

namespace EulerLibTests.Sequences;

public class PrimeNumbersFixture
{
    [Theory]
    [InlineData(0, 2)]
    [InlineData(1, 3)]
    [InlineData(2, 5)]
    [InlineData(3, 7)]
    [InlineData(4, 11)]
    public void PrimesTestCases(int index, int value)
    {
        var sequence = new PrimeNumbers().GenerateToMaximumSize(5);

        sequence.ElementAt(index).Should().Be(value);
    }

    [Theory]
    [InlineData(50, 47)]
    [InlineData(40, 37)]
    [InlineData(30, 29)]
    [InlineData(19, 19)]
    public void GenerateToMaximumValueTests(int maximumValue, int lastPrime)
    {
        var sequence = new PrimeNumbers().GenerateToMaximumValue(maximumValue).ToList();

        sequence.Last().Should().Be(lastPrime);
    }

    [Theory]
    [InlineData(5, 11)]
    [InlineData(10, 29)]
    [InlineData(15, 47)]
    [InlineData(20, 71)]
    [InlineData(100, 541)]
    [InlineData(20000,224737)]
    public void GenerateToMaximumSizeTests(int maximumSize, int lastPrime)
    {
        var sequence = new PrimeNumbers().GenerateToMaximumSize(maximumSize).ToList();

        sequence.Last().Should().Be(lastPrime);
    }

    [Fact]
    public void GenerateUsingEratosthenesSieveTest1()
    {
        var sequence = new PrimeNumbers().GenerateUsingEratosthenesSieve(20).ToList();

        sequence.Should().BeEquivalentTo(new[] { 2, 3, 5, 7, 11, 13, 17, 19 });
    }

    [Fact]
    public void GenerateUsingEratosthenesSieveTest2()
    {
        var sequence = new PrimeNumbers().GenerateUsingEratosthenesSieve(30).ToList();

        sequence.Should().BeEquivalentTo(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 });
    }
}