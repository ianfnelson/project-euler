using EulerLib.Extensions;

namespace EulerLibTests.Extensions;

[TestFixture]
public class RomanNumeralsExtensionsFixture
{
    [TestCase("XXFX", "F")]
    [TestCase("C%C", "%")]
    public void ParseRomanNumeral_InvalidRomanCharacter_Throws(string input, string expectedInvalidCharacter)
    {
        var ex = Assert.Throws<ArgumentException>(() => input.ParseRomanNumeral());
        
        ex.Message.Should().Contain("Invalid Roman numeral character: " + expectedInvalidCharacter);
    }

    [TestCase("I", 1)]
    [TestCase("II", 2)]
    [TestCase("III", 3)]
    [TestCase("IV", 4)]
    [TestCase("LVII", 57)]
    [TestCase("MMMMCCLXXXVI", 4286)]
    public void ParseRomanNumeral_ValidInput_ReturnsExpectedResult(string input, int expectedResult)
    {
        var result = input.ParseRomanNumeral();
        
        result.Should().Be(expectedResult);
    }
    
    [TestCase(-5)]
    [TestCase(0)]
    [TestCase(5000)]
    [TestCase(9678)]
    public void ToRomanNumeral_OutOfRange_Throws(int value)
    {
        var ex = Assert.Throws<ArgumentOutOfRangeException>(() => value.ToRomanNumeral());
        
        ex.Message.Should().Contain("Input must be between 1 and 4999.");
    }

    [TestCase(1, "I")]
    [TestCase(2, "II")]
    [TestCase(4, "IV")]
    [TestCase(19, "XIX")]
    [TestCase(2024, "MMXXIV")]
    public void ToRomanNumeral_ValidInput_ReturnsExpectedResult(int value, string expectedResult)
    {
        var result = value.ToRomanNumeral();
        
        result.Should().Be(expectedResult);
    }

    [TestCase("XIIII", "XIV")]
    public void SimplifyRomanNumeral_ValidInput_ReturnsExpectedOutput(string value, string expectedResult)
    {
        var result = value.SimplifyRomanNumeral();
        
        result.Should().Be(expectedResult);
    }
}