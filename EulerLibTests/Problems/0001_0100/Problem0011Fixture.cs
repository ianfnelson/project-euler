using EulerLib.Problems;

namespace EulerLibTests.Problems
{
    [TestFixture]
    public class Problem0011Fixture
    {
        [TestCase("problem0011example2.txt", 2, 945)]
        public void MaximumProductInAGrid_FindsHorizontals(string filename, int adjacentNumbers, int expectedResult)
        {
            DoMaximumProductInAGridTest(filename,adjacentNumbers, expectedResult);
        }

        [TestCase("problem0011example3.txt", 2, 1869)]
        public void MaximumProductInAGrid_FindsVerticals(string filename, int adjacentNumbers, int expectedResult)
        {
            DoMaximumProductInAGridTest(filename, adjacentNumbers, expectedResult);
        }

        [TestCase("problem0011example1.txt", 2, 4005)]
        public void MaximumProductInAGrid_FindsUphillDiagonals(string filename, int adjacentNumbers, int expectedResult)
        {
            DoMaximumProductInAGridTest(filename, adjacentNumbers, expectedResult);
        }

        [TestCase("problem0011example4.txt", 2, 4320)]
        public void MaximumProductInAGrid_FindsDownhillDiagonals(string filename, int adjacentNumbers, int expectedResult)
        {
            DoMaximumProductInAGridTest(filename, adjacentNumbers, expectedResult);
        }

        private void DoMaximumProductInAGridTest(string filename, int adjacentNumbers,int expectedResult)
        {
            var sut = new Problem0011();

            var result = sut.MaximumProductInAGrid($"TestFiles/{filename}", adjacentNumbers);

            result.Should().Be(expectedResult);
        }
    }
}