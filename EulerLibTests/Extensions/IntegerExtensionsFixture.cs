using EulerLib.Extensions;

namespace EulerLibTests.Extensions;

[TestFixture]
public class IntegerExtensionsFixture
{
    [TestCase(2, "2")]
    [TestCase(3, "6")]
    [TestCase(4, "24")]
    [TestCase(5, "120")]
    public void FactorialTests(int n, string expectedFactorial)
    {
        var result = n.Factorial();

        result.ToString().Should().Be(expectedFactorial);
    }

    [Test]
    public void DigitRotationsTest2845()
    {
        var result = 2845.DigitRotations().ToList();

        result.Should().BeEquivalentTo([2845, 8452, 4528, 5284]);
    }

    [Test]
    public void DigitRotationsTest197()
    {
        var result = 197.DigitRotations().ToList();

        result.Should().BeEquivalentTo([197, 971, 719]);
    }
        
    [Test]
    public void DigitRotationsTest111()
    {
        var result = 111.DigitRotations().ToList();

        result.Should().BeEquivalentTo([111]);
    }
}