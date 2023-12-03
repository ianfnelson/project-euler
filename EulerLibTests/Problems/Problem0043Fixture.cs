using EulerLib.Problems;
using FluentAssertions;

namespace EulerLibTests.Problems;

[TestFixture]
public class Problem0043Fixture
{
    private Problem0043 _sut;

    [SetUp]
    public void SetUp()
    {
        _sut = new Problem0043();
    }

    [TestCase("1406357289")]
    [TestCase("1430952867")]
    public void HasDesiredProperty_PositiveExamples(string pandigital)
    {
        Problem0043.HasDesiredProperty(pandigital).Should().BeTrue();
    }

    [TestCase("1406357892")]
    [TestCase("0123456789")]
    public void HasDesiredProperty_NegativeExamples(string pandigital)
    {
        Problem0043.HasDesiredProperty(pandigital).Should().BeFalse();
    }
}