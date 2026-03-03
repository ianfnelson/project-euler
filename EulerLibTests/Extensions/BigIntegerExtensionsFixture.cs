using System.Numerics;
using EulerLib.Extensions;

namespace EulerLibTests.Extensions;

public class BigIntegerExtensionsFixture
{
    [Theory]
    [InlineData("12345", 15)]
    [InlineData("1234567890", 45)]
    public void SumOfDigits_Tests(string value, int expectedSumOfDigits)
    {
        var bigint = BigInteger.Parse(value);

        var result = bigint.SumOfDigits();

        result.Should().Be(expectedSumOfDigits);
    }
}