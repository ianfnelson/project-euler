using EulerLib.Extensions;

namespace EulerLibTests.Extensions;

public class DivisorsExtensionFixture
{
    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(2, 3, 2)]
    [InlineData(4, 7, 3)]
    [InlineData(16, 31, 5)]
    [InlineData(220, 504, 12)]
    [InlineData(284, 504, 6)]
    public void DivisorsTests(int n, int divisorsSum, int divisorsCount)
    {
        // Arrange

        // Act
        var divisors = n.Divisors();

        // Assert
        divisors.Count().Should().Be(divisorsCount);
        divisors.Sum().Should().Be(divisorsSum);
    }

    [Theory]
    [InlineData(1, 0, 0)]
    [InlineData(2, 1, 1)]
    [InlineData(4, 3, 2)]
    [InlineData(16, 15, 4)]
    [InlineData(220, 284, 11)]
    [InlineData(284, 220, 5)]
    public void ProperDivisorsTests(int n, int divisorsSum, int divisorsCount)
    {
        // Arrange

        // Act
        var divisors = n.ProperDivisors();

        // Assert
        divisors.Count().Should().Be(divisorsCount);
        divisors.Sum().Should().Be(divisorsSum);
    }

    [Theory]
    [InlineData(4, new[] { 1, 2 })]
    public void ProperDivisors_ValuesTest(int n, int[] expectedDivisors)
    {
        var divisors = n.ProperDivisors();

        divisors.Should().BeEquivalentTo(expectedDivisors);
    }
}