using EulerLib.Sets;
using FluentAssertions;

namespace EulerLibTests.Sets;

[TestFixture]
public class PandigitalNumbersFixture
{
    [Test]
    public void GetPandigitalNumbers_startDigit1_endDigit1_Returns1()
    {
        PandigitalNumbers.Generate(1,1).Should().BeEquivalentTo("1");
    }

    [Test]
    public void GetPandigitalNumbers_startDigit1_endDigit2_Returns12And21()
    {
        PandigitalNumbers.Generate(1,2).Should().BeEquivalentTo("12", "21");
    }

    [Test]
    public void GetPandigitalNumbers_startDigit1_endDigit3_ReturnsExpectedSixNumbers()
    {
        PandigitalNumbers.Generate(1,3).Should().BeEquivalentTo("123", "132", "213", "231", "312", "321");
    }
    
    [Test]
    public void GetPandigitalNumbers_startDigit4_endDigit6_ReturnsExpectedSixNumbers()
    {
        PandigitalNumbers.Generate(4,6).Should().BeEquivalentTo("456", "465", "546", "564", "645", "654");
    }
}