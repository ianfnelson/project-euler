using EulerLib.Extensions;

namespace EulerLibTests.Extensions;

public class RomanNumeralsExtensionsFixture
{
    [Theory]
    [InlineData("XXFX", "F")]
    [InlineData("C%C", "%")]
    public void ParseRomanNumeral_InvalidRomanCharacter_Throws(string input, string expectedInvalidCharacter)
    {
        var ex = Assert.Throws<ArgumentException>(() => input.ParseRomanNumeral());
        
        ex.Message.Should().Contain("Invalid Roman numeral character: " + expectedInvalidCharacter);
    }

    [Theory]
    [InlineData("I", 1)]
    [InlineData("II", 2)]
    [InlineData("III", 3)]
    [InlineData("IV", 4)]
    [InlineData("LVII", 57)]
    [InlineData("MMMMCCLXXXVI", 4286)]
    public void ParseRomanNumeral_ValidInput_ReturnsExpectedResult(string input, int expectedResult)
    {
        var result = input.ParseRomanNumeral();
        
        result.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData(-5)]
    [InlineData(0)]
    [InlineData(5000)]
    [InlineData(9678)]
    public void ToRomanNumeral_OutOfRange_Throws(int value)
    {
        var ex = Assert.Throws<ArgumentOutOfRangeException>(() => value.ToRomanNumeral());
        
        ex.Message.Should().Contain("Input must be between 1 and 4999.");
    }

    [Theory]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    [InlineData(4, "IV")]
    [InlineData(19, "XIX")]
    [InlineData(2024, "MMXXIV")]
    public void ToRomanNumeral_ValidInput_ReturnsExpectedResult(int value, string expectedResult)
    {
        var result = value.ToRomanNumeral();
        
        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("XIIII", "XIV")]
    public void SimplifyRomanNumeral_ValidInput_ReturnsExpectedOutput(string value, string expectedResult)
    {
        var result = value.SimplifyRomanNumeral();
        
        result.Should().Be(expectedResult);
    }
}