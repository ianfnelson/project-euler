using EulerLib.Problems;

namespace EulerLibTests.Problems;

public class Problem0029Fixture
{
    [Fact]
    public void DistinctPowersThrough5Gives15DistinctTerms()
    {
        var count = Problem0029.CountDistinctPowersThrough(5);
        
        count.Should().Be(15);
    }
}