using System.Security.Cryptography.X509Certificates;
using EulerLib.Problems;
using FluentAssertions;
using NUnit.Framework;

namespace EulerLibTests.Problems
{
    [TestFixture]
    public class Problem0012Fixture
    {
        [Test]
        public void FirstTriangularNumberToHaveOverFiveDivisorsIs28()
        {
            var sut = new Problem0012();

            var result = sut.FirstTriangularNumberWithMoreThanXDivisors(5);

            result.Should().Be(28);
        }
    }
}