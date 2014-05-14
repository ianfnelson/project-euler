using System;
using EulerLib.IntegerExtensions;
using NUnit.Framework;

namespace EulerLibTests.IntegerExtensions
{
    [TestFixture]
    public class SequenceMembershipExtensionsFixture
    {
        [TestCase(1, false)]
        [TestCase(2, false)]
        [TestCase(6, false)]
        [TestCase(12, true)]
        [TestCase(18, true)]
        [TestCase(54, true)]
        [TestCase(101, false)]
        [TestCase(102, true)]
        public void IsAbundantTestCases(int n, bool isAbundant)
        {
            // AAA
            Assert.That(n.IsAbundant(), Is.EqualTo(isAbundant));
        }

        [TestCase(1, true)]
        [TestCase(2, true)]
        [TestCase(6, false)]
        [TestCase(12, false)]
        [TestCase(18, false)]
        [TestCase(53, true)]
        [TestCase(101, true)]
        [TestCase(102, false)]
        public void IsDeficientTestCases(int n, bool isDeficient)
        {
            // AAA
            Assert.That(n.IsDeficient(), Is.EqualTo(isDeficient));
        }

        [TestCase(1, false)]
        [TestCase(2, false)]
        [TestCase(6, true)]
        [TestCase(28, true)]
        [TestCase(496, true)]
        [TestCase(8128, true)]
        [TestCase(8130, false)]
        public void IsPerfectTestCases(int n, bool isPerfect)
        {
            // AAA
            Assert.That(n.IsPerfect(), Is.EqualTo(isPerfect));
        }

        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(7, true)]
        [TestCase(9, false)]
        [TestCase(11, true)]
        [TestCase(13, true)]
        [TestCase(15, false)]
        [TestCase(17, true)]
        [TestCase(19, true)]
        public void IsPrimeTestCases(int n, bool isPrime)
        {
            // AAA
            Assert.That(n.IsPrime(), Is.EqualTo(isPrime));
        }
    }
}
