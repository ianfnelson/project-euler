using EulerLib.Problems;
using FluentAssertions;
using NUnit.Framework;

namespace EulerLibTests.Problems
{
    [TestFixture]
    public class Problem0026Fixture
    {
        [TestCase(2, 0)]
        [TestCase(3, 1)]
        [TestCase(4, 0)]
        [TestCase(5, 0)]
        [TestCase(6, 1)]
        [TestCase(7, 6)]
        [TestCase(8, 0)]
        [TestCase(9, 1)]
        [TestCase(10, 0)]
        public void ReciprocalCycleLength_Tests(int denominator, int expectedCycleLength)
        {
            var sut = new Problem0026();

            var cycleLength = Problem0026.ReciprocalCycleLength(denominator);

            cycleLength.Should().Be(expectedCycleLength);
        }

        [TestCase(4, 3)]
        [TestCase(10, 7)]
        public void MaximumReciprocalCycleLengthTest(int maximumDenomator, int expectedMaximumCycleLength)
        {
            var sut = new Problem0026();

            var cycleLength = Problem0026.DenominatorWIthMaximumReciprocalCycleLength(maximumDenomator);

            cycleLength.Should().Be(expectedMaximumCycleLength);
        }
    }
}