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
                throw new ArgumentOutOfRangeException(string.Format("Needed 5 cards, received {0}", Cards.Count),
                    "cards");

            Interpret();
        }


        public ICollection<Card> Cards { get; private set; }

        public Ranking Ranking { get; private set; }

        public IList<Value> ValuesList { get; private set; }

        private void Interpret()
        {
            throw new NotImplementedException();
        }
    }
}