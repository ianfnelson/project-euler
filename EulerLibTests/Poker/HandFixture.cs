using AutoFixture;
using EulerLib.Poker;

namespace EulerLibTests.Poker;

[TestFixture]
public class HandFixture
{
    [SetUp]
    public void SetUp()
    {
        fixture = new Fixture();
    }

    private static IFixture fixture;

    [TestCase("9D 9C AS AH AC")]
    [TestCase("2D 8C 2H 8S 2S")]
    public void CanIdentifyFullHouse(string input)
    {
        var hand = Hand.Parse(input);

        hand.Ranking.Should().Be(Ranking.FullHouse);
    }

    [TestCase("2D 9C AS AH AC")]
    [TestCase("2D 9C 2H 8S 2S")]
    public void CanIdentifyThreeOfAKind(string input)
    {
        var hand = Hand.Parse(input);

        hand.Ranking.Should().Be(Ranking.ThreeOfAKind);
    }

    [TestCase("AD 9C AS AH AC")]
    [TestCase("2D 9C 2H 2C 2S")]
    public void CanIdentifyFourOfAKind(string input)
    {
        var hand = Hand.Parse(input);

        hand.Ranking.Should().Be(Ranking.FourOfAKind);
    }

    [TestCase("5D 8C 9S JS AC")]
    [TestCase("2C 5C 7D 8S QH")]
    public void CanIdentifyHighCard(string input)
    {
        var hand = Hand.Parse(input);

        hand.Ranking.Should().Be(Ranking.HighCard);
    }

    [TestCase("5H 5C 6S 7S KD")]
    [TestCase("4D 6S 9H QH QC")]
    public void CanIdentifyPair(string input)
    {
        var hand = Hand.Parse(input);

        hand.Ranking.Should().Be(Ranking.Pair);
    }

    [TestCase("5H 5C 6S 7S 6D")]
    [TestCase("9D 6S 9H QH QC")]
    public void CanIdentifyTwoPair(string input)
    {
        var hand = Hand.Parse(input);

        hand.Ranking.Should().Be(Ranking.TwoPair);
    }

    [TestCase("3D 6D 7D TD QD")]
    [TestCase("9S 3S 2S QS KS")]
    public void CanIdentifyFlush(string input)
    {
        var hand = Hand.Parse(input);

        hand.Ranking.Should().Be(Ranking.Flush);
    }

    [TestCase("TD JH QC KS AD")]
    [TestCase("9D TH JC QS KD")]
    [TestCase("8D 9H TC JS QD")]
    [TestCase("7D 8H 9C TS JD")]
    [TestCase("6D 7H 8C 9S TD")]
    [TestCase("5D 6H 7C 8S 9D")]
    [TestCase("4D 5H 6H 7S 8D")]
    [TestCase("3S 4H 5C 6S 7D")]
    [TestCase("2D 3H 4S 5H 6D")]
    [TestCase("AD 2H 3C 4S 5D")]
    public void CanIdentifyStraight(string input)
    {
        var hand = Hand.Parse(input);

        hand.Ranking.Should().Be(Ranking.Straight);
    }

    [TestCase("TD JD QD KD AD")]
    [TestCase("9S TS JS QS KS")]
    [TestCase("8C 9C TC JC QC")]
    [TestCase("7H 8H 9H TH JH")]
    [TestCase("6C 7C 8C 9C TC")]
    [TestCase("5H 6H 7H 8H 9H")]
    [TestCase("4S 5S 6S 7S 8S")]
    [TestCase("3D 4D 5D 6D 7D")]
    [TestCase("2C 3C 4C 5C 6C")]
    [TestCase("AH 2H 3H 4H 5H")]
    public void CanIdentifyStraightFlush(string input)
    {
        var hand = Hand.Parse(input);

        hand.Ranking.Should().Be(Ranking.StraightFlush);
    }

    [TestCase("5H 6H 7H 8H 9H", "AD 9C AS AH AC", 1)]
    [TestCase("5H 6H 7H 8H 9H", "2D 8C 2H 8S 2S", 1)]
    [TestCase("5H 6H 7H 8H 9H", "9S 3S 2S QS KS", 1)]
    [TestCase("5H 6H 7H 8H 9H", "7D 8H 9C TS JD", 1)]
    [TestCase("5H 6H 7H 8H 9H", "2D 9C 2H 8S 2S", 1)]
    [TestCase("5H 6H 7H 8H 9H", "9D 6S 9H QH QC", 1)]
    [TestCase("5H 6H 7H 8H 9H", "4D 6S 9H QH QC", 1)]
    [TestCase("5H 6H 7H 8H 9H", "2C 5C 7D 8S QH", 1)]
    public void InterRankComparisons_StraightFlush(string handInput, string otherHandInput, int expectedResult)
    {
        DoHandComparison(handInput, otherHandInput, expectedResult);
    }

    [TestCase("AD 9C AS AH AC", "5H 6H 7H 8H 9H", -1)]
    [TestCase("AD 9C AS AH AC", "2D 8C 2H 8S 2S", 1)]
    [TestCase("AD 9C AS AH AC", "9S 3S 2S QS KS", 1)]
    [TestCase("AD 9C AS AH AC", "7D 8H 9C TS JD", 1)]
    [TestCase("AD 9C AS AH AC", "2D 9C 2H 8S 2S", 1)]
    [TestCase("AD 9C AS AH AC", "9D 6S 9H QH QC", 1)]
    [TestCase("AD 9C AS AH AC", "4D 6S 9H QH QC", 1)]
    [TestCase("AD 9C AS AH AC", "2C 5C 7D 8S QH", 1)]
    public void InterRankComparisons_FourOfAKind(string handInput, string otherHandInput, int expectedResult)
    {
        DoHandComparison(handInput, otherHandInput, expectedResult);
    }

    [TestCase("2D 8C 2H 8S 2S", "5H 6H 7H 8H 9H", -1)]
    [TestCase("2D 8C 2H 8S 2S", "AD 9C AS AH AC", -1)]
    [TestCase("2D 8C 2H 8S 2S", "9S 3S 2S QS KS", 1)]
    [TestCase("2D 8C 2H 8S 2S", "7D 8H 9C TS JD", 1)]
    [TestCase("2D 8C 2H 8S 2S", "2D 9C 2H 8S 2S", 1)]
    [TestCase("2D 8C 2H 8S 2S", "9D 6S 9H QH QC", 1)]
    [TestCase("2D 8C 2H 8S 2S", "4D 6S 9H QH QC", 1)]
    [TestCase("2D 8C 2H 8S 2S", "2C 5C 7D 8S QH", 1)]
    public void InterRankComparisons_FullHouse(string handInput, string otherHandInput, int expectedResult)
    {
        DoHandComparison(handInput, otherHandInput, expectedResult);
    }

    [TestCase("9S 3S 2S QS KS", "5H 6H 7H 8H 9H", -1)]
    [TestCase("9S 3S 2S QS KS", "AD 9C AS AH AC", -1)]
    [TestCase("9S 3S 2S QS KS", "2D 8C 2H 8S 2S", -1)]
    [TestCase("9S 3S 2S QS KS", "7D 8H 9C TS JD", 1)]
    [TestCase("9S 3S 2S QS KS", "2D 9C 2H 8S 2S", 1)]
    [TestCase("9S 3S 2S QS KS", "9D 6S 9H QH QC", 1)]
    [TestCase("9S 3S 2S QS KS", "4D 6S 9H QH QC", 1)]
    [TestCase("9S 3S 2S QS KS", "2C 5C 7D 8S QH", 1)]
    public void InterRankComparisons_Flush(string handInput, string otherHandInput, int expectedResult)
    {
        DoHandComparison(handInput, otherHandInput, expectedResult);
    }

    [TestCase("7D 8H 9C TS JD", "5H 6H 7H 8H 9H", -1)]
    [TestCase("7D 8H 9C TS JD", "AD 9C AS AH AC", -1)]
    [TestCase("7D 8H 9C TS JD", "2D 8C 2H 8S 2S", -1)]
    [TestCase("7D 8H 9C TS JD", "9S 3S 2S QS KS", -1)]
    [TestCase("7D 8H 9C TS JD", "2D 9C 2H 8S 2S", 1)]
    [TestCase("7D 8H 9C TS JD", "9D 6S 9H QH QC", 1)]
    [TestCase("7D 8H 9C TS JD", "4D 6S 9H QH QC", 1)]
    [TestCase("7D 8H 9C TS JD", "2C 5C 7D 8S QH", 1)]
    public void InterRankComparisons_Straight(string handInput, string otherHandInput, int expectedResult)
    {
        DoHandComparison(handInput, otherHandInput, expectedResult);
    }

    [TestCase("2D 9C 2H 8S 2S", "5H 6H 7H 8H 9H", -1)]
    [TestCase("2D 9C 2H 8S 2S", "AD 9C AS AH AC", -1)]
    [TestCase("2D 9C 2H 8S 2S", "2D 8C 2H 8S 2S", -1)]
    [TestCase("2D 9C 2H 8S 2S", "9S 3S 2S QS KS", -1)]
    [TestCase("2D 9C 2H 8S 2S", "7D 8H 9C TS JD", -1)]
    [TestCase("2D 9C 2H 8S 2S", "9D 6S 9H QH QC", 1)]
    [TestCase("2D 9C 2H 8S 2S", "4D 6S 9H QH QC", 1)]
    [TestCase("2D 9C 2H 8S 2S", "2C 5C 7D 8S QH", 1)]
    public void InterRankComparisons_ThreeOfAKind(string handInput, string otherHandInput, int expectedResult)
    {
        DoHandComparison(handInput, otherHandInput, expectedResult);
    }

    [TestCase("9D 6S 9H QH QC", "5H 6H 7H 8H 9H", -1)]
    [TestCase("9D 6S 9H QH QC", "AD 9C AS AH AC", -1)]
    [TestCase("9D 6S 9H QH QC", "2D 8C 2H 8S 2S", -1)]
    [TestCase("9D 6S 9H QH QC", "9S 3S 2S QS KS", -1)]
    [TestCase("9D 6S 9H QH QC", "7D 8H 9C TS JD", -1)]
    [TestCase("9D 6S 9H QH QC", "2D 9C 2H 8S 2S", -1)]
    [TestCase("9D 6S 9H QH QC", "4D 6S 9H QH QC", 1)]
    [TestCase("9D 6S 9H QH QC", "2C 5C 7D 8S QH", 1)]
    public void InterRankComparisons_TwoPair(string handInput, string otherHandInput, int expectedResult)
    {
        DoHandComparison(handInput, otherHandInput, expectedResult);
    }

    [TestCase("4D 6S 9H QH QC", "5H 6H 7H 8H 9H", -1)]
    [TestCase("4D 6S 9H QH QC", "AD 9C AS AH AC", -1)]
    [TestCase("4D 6S 9H QH QC", "2D 8C 2H 8S 2S", -1)]
    [TestCase("4D 6S 9H QH QC", "9S 3S 2S QS KS", -1)]
    [TestCase("4D 6S 9H QH QC", "7D 8H 9C TS JD", -1)]
    [TestCase("4D 6S 9H QH QC", "2D 9C 2H 8S 2S", -1)]
    [TestCase("4D 6S 9H QH QC", "9D 6S 9H QH QC", -1)]
    [TestCase("4D 6S 9H QH QC", "2C 5C 7D 8S QH", 1)]
    public void InterRankComparisons_Pair(string handInput, string otherHandInput, int expectedResult)
    {
        DoHandComparison(handInput, otherHandInput, expectedResult);
    }

    [TestCase("2C 5C 7D 8S QH", "5H 6H 7H 8H 9H", -1)]
    [TestCase("2C 5C 7D 8S QH", "AD 9C AS AH AC", -1)]
    [TestCase("2C 5C 7D 8S QH", "2D 8C 2H 8S 2S", -1)]
    [TestCase("2C 5C 7D 8S QH", "9S 3S 2S QS KS", -1)]
    [TestCase("2C 5C 7D 8S QH", "7D 8H 9C TS JD", -1)]
    [TestCase("2C 5C 7D 8S QH", "2D 9C 2H 8S 2S", -1)]
    [TestCase("2C 5C 7D 8S QH", "9D 6S 9H QH QC", -1)]
    [TestCase("2C 5C 7D 8S QH", "4D 6S 9H QH QC", -1)]
    public void InterRankComparisons_HighCard(string handInput, string otherHandInput, int expectedResult)
    {
        DoHandComparison(handInput, otherHandInput, expectedResult);
    }

    [TestCase("2C KC 7D 8S 5H", "2H QS 7H 8D 5C", 1)]
    [TestCase("2H QS 7H 8D 5C", "2C KC 7D 8S 5H", -1)]
    [TestCase("2C QC 7D 9S 5H", "2H QS 7H 8D 5C", 1)]
    [TestCase("2H QS 7H 8D 5C", "2C QC 7D 9S 5H", -1)]
    [TestCase("2C QC 8D 9S 5H", "2H QS 7H 9D 5C", 1)]
    [TestCase("2H QS 7H 9D 5C", "2C QC 8D 9S 5H", -1)]
    [TestCase("2C QC 8D 9S 6H", "2H QS 8H 9D 5C", 1)]
    [TestCase("2H QS 8H 9D 5C", "2C QC 8D 9S 6H", -1)]
    [TestCase("3C QC 8D 9S 6H", "2H QS 8H 9D 6C", 1)]
    [TestCase("2H QS 8H 9D 6C", "3C QC 8D 9S 6H", -1)]
    [TestCase("2H QS 8H 9D 6C", "2C QC 8D 9S 6H", 0)]
    public void IntraRankComparisons_HighCard(string handInput, string otherHandInput, int expectedResult)
    {
        DoHandComparison(handInput, otherHandInput, expectedResult);
    }

    [TestCase("2C KC 7C 8C 5C", "2H QH 7H 8H 5H", 1)]
    [TestCase("2C QC 7C 8C 5C", "2H KH 7H 8H 5H", -1)]
    [TestCase("2C QC 7C 9C 5C", "2H QH 7H 8H 5H", 1)]
    [TestCase("2C QC 7C 8C 5C", "2H QH 7H 9H 5H", -1)]
    [TestCase("2C QC 8C 9C 5C", "2H QH 7H 9H 5H", 1)]
    [TestCase("2S QS 7S 9S 5S", "2D QD 8D 9D 5D", -1)]
    [TestCase("2S QS 8S 9S 6S", "2D QD 8D 9D 5D", 1)]
    [TestCase("2S QS 8S 9S 5S", "2D QD 8D 9D 6D", -1)]
    [TestCase("3S QS 8S 9S 6S", "2D QD 8D 9D 6D", 1)]
    [TestCase("2S QS 8S 9S 6S", "3D QD 8D 9D 6D", -1)]
    [TestCase("2S QS 8S 9S 6S", "2D QD 8D 9D 6D", 0)]
    public void IntraRankComparisons_Flush(string handInput, string otherHandInput, int expectedResult)
    {
        DoHandComparison(handInput, otherHandInput, expectedResult);
    }

    [TestCase("4D 6S 9H QH QC", "4H 6C 9S JS JD", 1)]
    [TestCase("4H 6C 9S JS JD", "4D 6S 9H QH QC", -1)]
    [TestCase("4D 6S 9H QH QC", "4H 6C 8S QS QD", 1)]
    [TestCase("4H 6C 8S QS QD", "4D 6S 9H QH QC", -1)]
    [TestCase("4D 6S 9H QH QC", "4H 5C 9S QS QD", 1)]
    [TestCase("4H 5C 9S QS QD", "4D 6S 9H QH QC", -1)]
    [TestCase("4D 6S 9H QH QC", "3H 6C 9S QS QD", 1)]
    [TestCase("3H 6C 9S QS QD", "4D 6S 9H QH QC", -1)]
    [TestCase("4D 6S 9H QH QC", "4H 6C 9S QS QD", 0)]
    public void IntraRankComparisons_Pair(string handInput, string otherHandInput, int expectedResult)
    {
        DoHandComparison(handInput, otherHandInput, expectedResult);
    }

    [TestCase("9D 6S 9H QH QC", "9C 6H 9S JS JD", 1)]
    [TestCase("9C 6H 9S JS JD", "9D 6S 9H QH QC", -1)]
    [TestCase("9D 6S 9H QH QC", "8C 6H 8S QS QD", 1)]
    [TestCase("8C 6H 8S QS QD", "9D 6S 9H QH QC", -1)]
    [TestCase("9D 6S 9H QH QC", "9C 5H 9S QS QD", 1)]
    [TestCase("9C 5H 9S QS QD", "9D 6S 9H QH QC", -1)]
    [TestCase("9D 6S 9H QH QC", "9C 6H 9S QS QD", 0)]
    public void IntraRankComparisons_TwoPair(string handInput, string otherHandInput, int expectedResult)
    {
        DoHandComparison(handInput, otherHandInput, expectedResult);
    }

    [TestCase("3D 9C 3H 8S 3S", "2C 9H 2H 8C 2S", 1)]
    [TestCase("2C 9H 2H 8C 2H", "3D 9C 3H 8S 3S", -1)]
    public void IntraRankComparisons_ThreeOfAKind(string handInput, string otherHandInput, int expectedResult)
    {
        DoHandComparison(handInput, otherHandInput, expectedResult);
    }

    [TestCase("3D 9C 3H 3S 3C", "2C 9H 2H 2D 2S", 1)]
    [TestCase("2C 9H 2H 2D 2S", "3D 9C 3H 3S 3C", -1)]
    public void IntraRankComparisons_FullHouse(string handInput, string otherHandInput, int expectedResult)
    {
        DoHandComparison(handInput, otherHandInput, expectedResult);
    }

    [TestCase("3D 3C 3H 8S 3S", "2C 2H 2H 8C 2H", 1)]
    [TestCase("2C 2H 2H 8C 2H", "3D 3C 3H 8S 3S", -1)]
    public void IntraRankComparisons_FourOfAKind(string handInput, string otherHandInput, int expectedResult)
    {
        DoHandComparison(handInput, otherHandInput, expectedResult);
    }

    [TestCase("TC JS QH KD AC", "9D TH JC QS KH", 1)]
    [TestCase("9D TH JC QS KH", "TC JS QH KD AC", -1)]
    [TestCase("2C 3S 4H 5D 6C", "AD 2H 3C 4S 5H", 1)]
    [TestCase("AD 2H 3C 4S 5D", "2C 3S 4H 5D 6C", -1)]
    [TestCase("7D 8H 9C TS JD", "7C 8S 9H TD JC", 0)]
    public void IntraRankComparisons_Straight(string handInput, string otherHandInput, int expectedResult)
    {
        DoHandComparison(handInput, otherHandInput, expectedResult);
    }

    [TestCase("TC JC QC KC AC", "9H TH JH QH KH", 1)]
    [TestCase("9C TC JC QC KC", "TS JS QS KS AS", -1)]
    [TestCase("2S 3S 4S 5S 6S", "AD 2D 3D 4D 5D", 1)]
    [TestCase("AD 2D 3D 4D 5D", "2C 3C 4C 5C 6C", -1)]
    [TestCase("7H 8H 9H TH JH", "7C 8C 9C TC JC", 0)]
    public void IntraRankComparisons_StraightFlush(string handInput, string otherHandInput, int expectedResult)
    {
        DoHandComparison(handInput, otherHandInput, expectedResult);
    }

    private static void DoHandComparison(string handInput, string otherHandInput, int expectedResult)
    {
        var hand = Hand.Parse(handInput);
        var otherHand = Hand.Parse(otherHandInput);

        var result = hand.CompareTo(otherHand);

        result.Should().Be(expectedResult);
    }

    [Test]
    public void ConstructorThrowsIfNoCardsPassed()
    {
        var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Hand(new Card[] {}));

        ex.ParamName.Should().Be("cards");
    }

    [Test]
    public void ConstructorThrowsIfNullCardsPassed()
    {
        var ex = Assert.Throws<ArgumentNullException>(() => new Hand(null));

        ex.ParamName.Should().Be("cards");
    }

    [Test]
    public void ConstructorThrowsIfTooFewCardsPassed()
    {
        for (var i = 1; i < 5; i++)
        {
            var cards = Enumerable.Range(1,i).Select(x => Card.Parse("2H"));

            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Hand(cards));

            ex.ParamName.Should().Be("cards");
        }
    }

    [Test]
    public void ConstructorThrowsIfTooManyCardsPassed()
    {
        for (var i = 6; i < 10; i++)
        {
            var cards = Enumerable.Range(1,i).Select(x => Card.Parse("2H"));

            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Hand(cards));

            ex.ParamName.Should().Be("cards");
        }
    }
}