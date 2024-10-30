using EulerLib.Problems;

namespace EulerLibTests.Problems
{
    [TestFixture]
    public class Problem0018Fixture
    {
        [Test]
        public void MaxSumThroughSampleIs23()
        {
            var file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestFiles/problem0018example.txt");

            var sut = new Problem0018();

            var result = Problem0018.MaximumPathThroughTriangle(file);

            result.Should().Be(23);
        }
    }
}