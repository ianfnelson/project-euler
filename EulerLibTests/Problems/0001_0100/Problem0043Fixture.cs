using EulerLib.Problems;
using FluentAssertions;

namespace EulerLibTests.Problems;

public class Problem0043Fixture
{
    [Theory]
    [InlineData("1406357289")]
    [InlineData("1430952867")]
    public void HasDesiredProperty_PositiveExamples(string pandigital)
    {
        Problem0043.HasDesiredProperty(pandigital).Should().BeTrue();
    }

    [Theory]
    [InlineData("1406357892")]
    [InlineData("0123456789")]
    public void HasDesiredProperty_NegativeExamples(string pandigital)
    {
        Problem0043.HasDesiredProperty(pandigital).Should().BeFalse();
    }
}