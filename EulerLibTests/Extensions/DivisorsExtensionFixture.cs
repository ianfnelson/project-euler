using EulerLib.Extensions;

namespace EulerLibTests.Extensions
{
    [TestFixture]
    public class DivisorsExtensionFixture
    {
        [TestCase(1, 1, 1)]
        [TestCase(2, 3, 2)]
        [TestCase(4, 7, 3)]
        [TestCase(16, 31, 5)]
        [TestCase(220, 504, 12)]
        [TestCase(284, 504, 6)]
        public void DivisorsTests(int n, int divisorsSum, int divisorsCount)
        {
            // Arrange

            // Act
            var divisors = n.Divisors();

            // Assert
            Assert.That(divisors.Count(), Is.EqualTo(divisorsCount));
            Assert.That(divisors.Sum(), Is.EqualTo(divisorsSum));
        }

        [TestCase(1, 0, 0)]
        [TestCase(2, 1, 1)]
        [TestCase(4, 3, 2)]
        [TestCase(16, 15, 4)]
        [TestCase(220, 284, 11)]
        [TestCase(284, 220, 5)]
        public void ProperDivisorsTests(int n, int divisorsSum, int divisorsCount)
        {
            // Arrange

            // Act
            var divisors = n.ProperDivisors();

            // Assert
            Assert.That(divisors.Count(), Is.EqualTo(divisorsCount));
            Assert.That(divisors.Sum(), Is.EqualTo(divisorsSum));
        }

        [TestCase(4, new[] { 1, 2 })]
        public void Foo(int n, int[] expectedDivisors)
        {
            var divisors = n.ProperDivisors();

            divisors.Should().AllBeEquivalentTo(expectedDivisors);
        }
    }
}