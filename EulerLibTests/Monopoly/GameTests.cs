using EulerLib.Monopoly;

namespace EulerLibTests.Monopoly;

[TestFixture]
public class GameTests
{
    [Test]
    [Ignore("Slow-running")]
    public void GameTest_SixSidedDice_TopSquaresAreAsExpected()
    {
        var game = new Game(6);

        var frequencies = game.Simulate(1000000000);

        var modalString =
            string.Concat(
                frequencies.OrderByDescending(kv => kv.Value)
                    .Take(3)
                    .Select(kv => kv.Key.ToString("D2"))
            );

        modalString.Should().Be("102400");
    }
}