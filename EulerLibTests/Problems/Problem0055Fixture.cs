using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EulerLib.Problems;
using FluentAssertions;
using NUnit.Framework;

namespace EulerLibTests.Problems
{
    [TestFixture]
    public class Problem0055Fixture
    {
        [TestCase(3, false)]
        [TestCase(47, false)]
        [TestCase(349,false)]
        [TestCase(196,true)]
        [TestCase(4994, true)]
        public void IsLychrelTests(int n, bool expectedValue)
        {
            var sut = new Problem0055();

            var actual = Problem0055.IsLychrel(n);

            actual.Should().Be(expectedValue);
        }
    }
}
