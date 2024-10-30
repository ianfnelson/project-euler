using EulerLib.Problems;

namespace EulerLibTests.Problems;

[TestFixture]
public class Problem0054Fixture
{
    [Test]
    public void Player1Wins3HandsInExample()
    {
        var file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestFiles/problem0054example.txt");

        var sut = new Problem0054();

        var result = sut.CountPlayer1WinsInFile(file);

        result.Should().Be(3);
    }
}