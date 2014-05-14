﻿using System.Linq;
using EulerLib.IntegerExtensions;
using NUnit.Framework;

namespace EulerLibTests.IntegerExtensions
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
        public void GetDivisorsTests(int n, int divisorsSum, int divisorsCount)
        {
            // Arrange

            // Act
            var divisors = n.GetDivisors();

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
        public void GetProperDivisorsTests(int n, int divisorsSum, int divisorsCount)
        {
            // Arrange

            // Act
            var divisors = n.GetProperDivisors();

            // Assert
            Assert.That(divisors.Count(), Is.EqualTo(divisorsCount));
            Assert.That(divisors.Sum(), Is.EqualTo(divisorsSum));
        }
    }
}