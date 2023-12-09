namespace EulerLib.Poker;

public class Card
{
    private Card(Value value, Suit suit)
    {
        Suit = suit;
        Value = value;
    }

    public Suit Suit { get; private set; }

    public Value Value { get; private set; }

    public static Card Parse(string input)
    {
        if (input is not { Length: 2 }) throw new ArgumentException("Must be two characters", nameof(input));

        var value = ParseValue(input[0]);
        var suit = ParseSuit(input[1]);

        return new Card(value, suit);
    }

    private static Value ParseValue(char input)
    {
        return input switch
        {
            'A' => Value.Ace,
            '2' => Value.Two,
            '3' => Value.Three,
            '4' => Value.Four,
            '5' => Value.Five,
            '6' => Value.Six,
            '7' => Value.Seven,
            '8' => Value.Eight,
            '9' => Value.Nine,
            'T' => Value.Ten,
            'J' => Value.Jack,
            'Q' => Value.Queen,
            'K' => Value.King,
            _ => throw new ArgumentException($"Cannot parse Value '{input}'", nameof(input))
        };
    }

    private static Suit ParseSuit(char input)
    {
        return input switch
        {
            'C' => Suit.Clubs,
            'D' => Suit.Diamonds,
            'H' => Suit.Hearts,
            'S' => Suit.Spades,
            _ => throw new ArgumentException($"Cannot parse Suit '{input}'", nameof(input))
        };
    }
}