using System;

namespace EulerLib.Poker
{
    public class Card
    {
        public Card(Value value, Suit suit)
        {
            Suit = suit;
            Value = value;
        }

        public Suit Suit { get; private set; }

        public Value Value { get; private set; }

        public static Card Parse(string input)
        {
            if (input == null || input.Length != 2) throw new ArgumentException("Must be two characters", "input");

            var value = ParseValue(input[0]);
            var suit = ParseSuit(input[1]);

            return new Card(value, suit);
        }

        private static Value ParseValue(char input)
        {
            switch (input)
            {
                case 'A':
                    return Value.Ace;
                case '2':
                    return Value.Two;
                case '3':
                    return Value.Three;
                case '4':
                    return Value.Four;
                case '5':
                    return Value.Five;
                case '6':
                    return Value.Six;
                case '7':
                    return Value.Seven;
                case '8':
                    return Value.Eight;
                case '9':
                    return Value.Nine;
                case 'T':
                    return Value.Ten;
                case 'J':
                    return Value.Jack;
                case 'Q':
                    return Value.Queen;
                case 'K':
                    return Value.King;
            }

            throw new ArgumentException(string.Format("Cannot parse Value '{0}'", input), "input");
        }

        private static Suit ParseSuit(char input)
        {
            switch (input)
            {
                case 'C':
                    return Suit.Clubs;
                case 'D':
                    return Suit.Diamonds;
                case 'H':
                    return Suit.Hearts;
                case 'S':
                    return Suit.Spades;
            }

            throw new ArgumentException(string.Format("Cannot parse Suit '{0}'", input), "input");
        }
    }
}