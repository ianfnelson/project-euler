using System.Linq;
using EulerLib.IntegerExtensions;
using FluentAssertions;
using NUnit.Framework;

namespace EulerLibTests.IntegerExtensions
{
    [TestFixture]
    public class PrimeFactorsExtensionFixture
    {
        // 13195 are 5, 7, 13 and 29.
        [Test]
        public void PrimeFactorsOf13195()
        {
            var sequence = 13195.PrimeFactors().ToList();

            sequence.ShouldAllBeEquivalentTo(new []{5,7,13,29});
        }

        [Test]
        public void PrimeFactorsOf12()
        {
            var sequence = 12.PrimeFactors().ToList();

            sequence.ShouldAllBeEquivalentTo(new[] { 2, 2, 3 });
        }
    }
}