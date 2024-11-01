﻿using EulerLib.Problems;

namespace EulerLibTests.Problems
{
    [TestFixture]
    public class Problem0012Fixture
    {
        [Test]
        public void FirstTriangularNumberToHaveOverFiveDivisorsIs28()
        {
            var sut = new Problem0012();

            var result = sut.FirstTriangularNumberWithMoreThanXDivisors(5);

            result.Should().Be(28);
        }
    }
}