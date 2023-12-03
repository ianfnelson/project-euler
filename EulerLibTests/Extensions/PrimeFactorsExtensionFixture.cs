using EulerLib.Extensions;
using FluentAssertions;

namespace EulerLibTests.Extensions
{
    [TestFixture]
    public class PrimeFactorsExtensionFixture
    {
        [Test]
        public void PrimeFactorsOf1()
        {
            var sequence = 1.PrimeFactors().ToList();

            sequence.Should().BeEmpty();
        }

        [Test]
        public void PrimeFactorsOf12()
        {
            var sequence = 12.PrimeFactors().ToList();
            
            sequence.Should().BeEquivalentTo(new[] {2, 2, 3});
        }

        [Test]
        public void PrimeFactorsOf13195()
        {
            var sequence = 13195.PrimeFactors().ToList();

            sequence.Should().BeEquivalentTo(new[] {5, 7, 13, 29});
        }

        [Test]
        public void PrimeFactorsOfFirst3500Numbers()
        {
            IEnumerable<long> result = null;

            for (int i = 1; i <= 3500; i++)
            {
                result = i.PrimeFactors().ToList();
            }

            result.Should().BeEquivalentTo(new[] {2,2,5,5,5,7});
        }
    }
}