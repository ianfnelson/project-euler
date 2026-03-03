using EulerLib.Extensions;

namespace EulerLibTests.Extensions;

public class SequenceMembershipExtensionsFixture
{
    [Theory]
    [InlineData(1, false)]
    [InlineData(2, false)]
    [InlineData(6, false)]
    [InlineData(12, true)]
    [InlineData(18, true)]
    [InlineData(54, true)]
    [InlineData(101, false)]
    [InlineData(102, true)]
    public void IsAbundantTestCases(int n, bool isAbundant)
    {
        // AAA
        n.IsAbundant().Should().Be(isAbundant);
    }

    [Theory]
    [InlineData(1, true)]
    [InlineData(2, true)]
    [InlineData(6, false)]
    [InlineData(12, false)]
    [InlineData(18, false)]
    [InlineData(53, true)]
    [InlineData(101, true)]
    [InlineData(102, false)]
    public void IsDeficientTestCases(int n, bool isDeficient)
    {
        // AAA
        n.IsDeficient().Should().Be(isDeficient);
    }

    [Theory]
    [InlineData(1, false)]
    [InlineData(2, false)]
    [InlineData(6, true)]
    [InlineData(28, true)]
    [InlineData(496, true)]
    [InlineData(8128, true)]
    [InlineData(8130, false)]
    public void IsPerfectTestCases(int n, bool isPerfect)
    {
        // AAA
        n.IsPerfect().Should().Be(isPerfect);
    }

    [Theory]
    [InlineData(1, false)]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(5, true)]
    [InlineData(7, true)]
    [InlineData(9, false)]
    [InlineData(11, true)]
    [InlineData(13, true)]
    [InlineData(15, false)]
    [InlineData(17, true)]
    [InlineData(19, true)]
    public void IsPrimeTestCases(int n, bool isPrime)
    {
        // AAA
        n.IsPrime().Should().Be(isPrime);
    }

    [Theory]
    [InlineData(1, true)]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(10, false)]
    [InlineData(11, true)]
    [InlineData(44, true)]
    [InlineData(46, false)]
    [InlineData(101, true)]
    [InlineData(151, true)]
    [InlineData(186, false)]
    [InlineData(1016101, true)]
    [InlineData(10178663, false)]
    public void IsPalindromicTestCases(int n, bool isPalindromic)
    {
        n.IsPalindromic().Should().Be(isPalindromic);
    }
}