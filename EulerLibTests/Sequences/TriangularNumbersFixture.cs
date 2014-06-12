﻿using EulerLib.Sequences;
using FluentAssertions;
using NUnit.Framework;

namespace EulerLibTests.Sequences
{
    [TestFixture]
    public class TriangularNumbersFixture
    {
        [Test]
        public void TriangularNumbers_GenerateToMaximumSize()
        {
            var sequence = new TriangularNumbers().GenerateToMaximumSize(10);

            sequence.ShouldAllBeEquivalentTo(new[] { 1, 3, 6, 10, 15, 21, 28, 36, 45, 55 });
        }

        [Test]
        public void TriangularNumbers_GenerateToMaximumValue()
        {
            var sequence = new TriangularNumbers().GenerateToMaximumValue(22);

            sequence.ShouldAllBeEquivalentTo(new[] { 1, 3, 6, 10, 15, 21 });
        }
    }
}