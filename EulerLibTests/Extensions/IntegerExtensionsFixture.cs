using EulerLib.Extensions;

namespace EulerLibTests.Extensions;

public class IntegerExtensionsFixture
{
    [Theory]
    [InlineData(2, "2")]
    [InlineData(3, "6")]
    [InlineData(4, "24")]
    [InlineData(5, "120")]
    public void FactorialTests(int n, string expectedFactorial)
    {
        var result = n.Factorial();

        result.ToString().Should().Be(expectedFactorial);
    }

    [Fact]
    public void DigitRotationsTest2845()
    {
        var result = 2845.DigitRotations().ToList();

        result.Should().BeEquivalentTo([2845, 8452, 4528, 5284]);
    }

    [Fact]
    public void DigitRotationsTest197()
    {
        var result = 197.DigitRotations().ToList();

        result.Should().BeEquivalentTo([197, 971, 719]);
    }
        
    [Fact]
    public void DigitRotationsTest111()
    {
        var result = 111.DigitRotations().ToList();

        result.Should().BeEquivalentTo([111]);
    }
}