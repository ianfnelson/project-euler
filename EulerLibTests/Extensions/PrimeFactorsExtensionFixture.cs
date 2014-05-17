using System.Linq;
using EulerLib.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace EulerLibTests.Extensions
{
    [TestFixture]
    public class PrimeFactorsExtensionFixture
    {
        [Test]
        public void PrimeFactorsOf12()
        {
            var sequence = 12.PrimeFactors().ToList();

            sequence.ShouldAllBeEquivalentTo(new[] {2, 2, 3});
        }

        [Test]
        public void PrimeFactorsOf13195()
        {
            var sequence = 13195.PrimeFactors().ToList();

            sequence.ShouldAllBeEquivalentTo(new[] {5, 7, 13, 29});
        }
    }
}