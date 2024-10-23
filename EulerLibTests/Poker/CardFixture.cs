using EulerLib.Poker;

namespace EulerLibTests.Poker
{
    [TestFixture]
    public class CardFixture
    {
        [TestCase("2C", Value.Two, Suit.Clubs)]
        [TestCase("3H", Value.Three, Suit.Hearts)]
        [TestCase("4S", Value.Four, Suit.Spades)]
        [TestCase("5D", Value.Five, Suit.Diamonds)]
        [TestCase("6C", Value.Six, Suit.Clubs)]
        [TestCase("7H", Value.Seven, Suit.Hearts)]
        [TestCase("8S", Value.Eight, Suit.Spades)]
        [TestCase("9D", Value.Nine, Suit.Diamonds)]
        [TestCase("TC", Value.Ten, Suit.Clubs)]
        [TestCase("JH", Value.Jack, Suit.Hearts)]
        [TestCase("QS", Value.Queen, Suit.Spades)]
        [TestCase("KD", Value.King, Suit.Diamonds)]
        [TestCase("AC", Value.Ace, Suit.Clubs)]
        public void ValidParseTests(string input, Value expectedValue, Suit expectedSuit)
        {
            var card = Card.Parse(input);

            card.Suit.Should().Be(expectedSuit);
            card.Value.Should().Be(expectedValue);
        }
        
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("2c")]
        [TestCase(" 2C")]
        [TestCase("2C ")]
        [TestCase("2A")]
        [TestCase("2B")]
        [TestCase("A2")]
        [TestCase("0C")]
        [TestCase("1C")]
        [TestCase("2")]
        [TestCase("C")]
        [TestCase("2CD")]
        public void InvalidParseTest(string input)
        {
            var ex = Assert.Throws<ArgumentException>(() => Card.Parse(input));

            Assert.That(ex.ParamName, Is.EqualTo("input"));
        }
    }
}