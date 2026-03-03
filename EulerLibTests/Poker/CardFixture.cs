using EulerLib.Poker;
using Value = EulerLib.Poker.Value;

namespace EulerLibTests.Poker;

public class CardFixture
{
    [Theory]
    [InlineData("2C", Value.Two, Suit.Clubs)]
    [InlineData("3H", Value.Three, Suit.Hearts)]
    [InlineData("4S", Value.Four, Suit.Spades)]
    [InlineData("5D", Value.Five, Suit.Diamonds)]
    [InlineData("6C", Value.Six, Suit.Clubs)]
    [InlineData("7H", Value.Seven, Suit.Hearts)]
    [InlineData("8S", Value.Eight, Suit.Spades)]
    [InlineData("9D", Value.Nine, Suit.Diamonds)]
    [InlineData("TC", Value.Ten, Suit.Clubs)]
    [InlineData("JH", Value.Jack, Suit.Hearts)]
    [InlineData("QS", Value.Queen, Suit.Spades)]
    [InlineData("KD", Value.King, Suit.Diamonds)]
    [InlineData("AC", Value.Ace, Suit.Clubs)]
    public void ValidParseTests(string input, Value expectedValue, Suit expectedSuit)
    {
        var card = Card.Parse(input);

        card.Suit.Should().Be(expectedSuit);
        card.Value.Should().Be(expectedValue);
    }
        
    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("2c")]
    [InlineData(" 2C")]
    [InlineData("2C ")]
    [InlineData("2A")]
    [InlineData("2B")]
    [InlineData("A2")]
    [InlineData("0C")]
    [InlineData("1C")]
    [InlineData("2")]
    [InlineData("C")]
    [InlineData("2CD")]
    public void InvalidParseTest(string input)
    {
        var ex = Assert.Throws<ArgumentException>(() => Card.Parse(input));

        ex.ParamName.Should().Be("input");
    }
}