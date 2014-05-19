using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerLib.Poker
{
    public class Hand
    {
        public Hand(IEnumerable<Card> cards)
        {
            if (cards == null) throw new ArgumentNullException("cards");

            Cards = new List<Card>(cards.ToList());

            if (Cards.Count != 5)
                throw new ArgumentOutOfRangeException("cards",
                    string.Format("Needed 5 cards, received {0}", Cards.Count),
                    "cards");

            Interpret();
        }

        public ICollection<Card> Cards { get; private set; }

        public Ranking Ranking { get; private set; }

        public IList<Value> ValuesList { get; private set; }

        private void Interpret()
        {
            // Divide and conquer - if multiple cards have the same value, 
            // this could be High Card, Flush, Straight or Straight Flush.
            // Else, must be pair, three of kind, two pair, four of a kind or Full House.

            if (Cards.Select(x => x.Value).Distinct().Count() == 5)
            {
                InterpretWhereAllValuesDiffer();
            }
            else
            {
                InterpretWhereSomeValuesMatch();
            }
        }

        private void InterpretWhereSomeValuesMatch()
        {
            var grouping = Cards.GroupBy(c => c.Value)
                                .OrderByDescending(g => g.Count())
                                .ThenByDescending(g => g.Key)
                                .ToList();

            if (grouping.Count == 4)
            {
                Ranking = Ranking.Pair;
            }
            else if (grouping.Count == 3)
            {
                switch (grouping[1].Count())
                {
                    case 1:
                        Ranking = Ranking.ThreeOfAKind;
                        break;
                    case 2:
                        Ranking = Ranking.TwoPair;
                        break;
                }
            }
            else if (grouping.Count == 2)
            {
                switch (grouping[0].Count())
                {
                    case 4:
                        Ranking = Ranking.FourOfAKind;
                        break;
                    case 3:
                        Ranking = Ranking.FullHouse;
                        break;
                }
            }
        }

        private void InterpretWhereAllValuesDiffer()
        {
            var isFlush = Cards.Select(c => c.Suit).Distinct().Count() == 1;
            var orderedCards = Cards.OrderBy(c => c.Value).ToList();

            var isStraight = (orderedCards[3].Value == Value.Five && orderedCards[4].Value == Value.Ace) ||
                             ((int) orderedCards[4].Value - (int) orderedCards[0].Value == 4);

            if (isFlush && isStraight)
            {
                Ranking = Ranking.StraightFlush;
            }
            else if (isStraight)
            {
                Ranking = Ranking.Straight;
            }
            else if (isFlush)
            {
                Ranking = Ranking.Flush;
            }
            else
            {
                Ranking = Ranking.HighCard;
            }
        }

        public static Hand Parse(string input)
        {
            return new Hand(input.Split(' ').Select(Card.Parse));
        }
    }
}