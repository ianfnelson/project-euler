using System;
using EulerLib.Poker;
using FluentAssertions;
using NUnit.Framework;
using Ploeh.AutoFixture;

namespace EulerLibTests.Poker
{
    [TestFixture]
    public class HandFixture
    {
        [SetUp]
        public void SetUp()
        {
            Fixture = new Fixture();
        }

        private static IFixture Fixture;

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
        public void CanIdentifyPairs(string input)
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

        [Test]
        public void ConstructorThrowsIfNoCardsPassed()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Hand(new Card[] { }));

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
                var cards = Fixture.CreateMany<Card>(i);

                var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Hand(cards));

                ex.ParamName.Should().Be("cards");
            }
        }

        [Test]
        public void ConstructorThrowsIfTooManyCardsPassed()
        {
            for (var i = 6; i < 10; i++)
            {
                var cards = Fixture.CreateMany<Card>(i);

                var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Hand(cards));

                ex.ParamName.Should().Be("cards");
            }
        }
    }
}