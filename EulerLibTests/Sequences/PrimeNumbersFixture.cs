using System;
using System.Linq;
using EulerLib.Sequences;
using FluentAssertions;
using NUnit.Framework;

namespace EulerLibTests.Sequences
{
    [TestFixture]
    public class PrimeNumbersFixture
    {
        [TestCase(0, 2)]
        [TestCase(1, 3)]
        [TestCase(2, 5)]
        [TestCase(3, 7)]
        [TestCase(4, 11)]
        public void PrimesTestCases(int index, int value)
        {
            var sequence = new PrimeNumbers().GenerateToMaximumSize(5);

            Assert.That(sequence.ElementAt(index), Is.EqualTo(value));
        }

        [TestCase(50, 47)]
        [TestCase(40, 37)]
        [TestCase(30, 29)]
        [TestCase(19, 19)]
        public void GenerateToMaximumValueTests(int maximumValue, int lastPrime)
        {
            var sequence = new PrimeNumbers().GenerateToMaximumValue(maximumValue).ToList();

            Assert.That(sequence.Last(), Is.EqualTo(lastPrime));
        }

        [TestCase(5, 11)]
        [TestCase(10, 29)]
        [TestCase(15, 47)]
        [TestCase(20, 71)]
        [TestCase(100, 541)]
        [TestCase(20000,224737)]
        public void GenerateToMaximumSizeTests(int maximumSize, int lastPrime)
        {
            var sequence = new PrimeNumbers().GenerateToMaximumSize(maximumSize).ToList();

            Assert.That(sequence.Last(), Is.EqualTo(lastPrime));
        }

        [Test]
        public void GenerateUsingEratosthenesSieveTest1()
        {
            var sequence = new PrimeNumbers().GenerateUsingEratosthenesSieve(20).ToList();

            sequence.ShouldAllBeEquivalentTo(new[] { 2, 3, 5, 7, 11, 13, 17, 19 });
        }

        [Test]
        public void GenerateUsingEratosthenesSieveTest2()
        {
            var sequence = new PrimeNumbers().GenerateUsingEratosthenesSieve(30).ToList();

            sequence.ShouldAllBeEquivalentTo(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 });
        }
    }
}