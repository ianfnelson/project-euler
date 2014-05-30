using EulerLib.Problems;
using FluentAssertions;
using NUnit.Framework;

namespace EulerLibTests.Problems
{
    [TestFixture]
    public class Problem0029Fixture
    {
        [Test]
        public void DistinctPowersThrough5Gives15DistinctTerms()
        {
            var sut = new Problem0029();

            var count = sut.CountDistinctPowersThrough(5);

            count.Should().Be(15);
        }
    }
}