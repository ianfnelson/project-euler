using System.Numerics;
using EulerLib.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace EulerLibTests.Extensions
{
    [TestFixture]
    public class IntegerExtensionsFixture
    {
        [TestCase(2, "2")]
        [TestCase(3, "6")]
        [TestCase(4, "24")]
        [TestCase(5, "120")]
        public void FactorialTests(int n, string expectedFactorial)
        {
            var result = n.Factorial();

            result.ToString().Should().Be(expectedFactorial);
        }
    }
}