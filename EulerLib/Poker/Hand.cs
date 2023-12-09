namespace EulerLib.Poker;

public class Hand : IComparable<Hand>
{
    public Hand(IEnumerable<Card> cards)
    {
        if (cards == null) throw new ArgumentNullException(nameof(cards));

        Cards = new List<Card>(cards.ToList());

        if (Cards.Count != 5)
            throw new ArgumentOutOfRangeException(nameof(cards),
                $"Needed 5 cards, received {Cards.Count}",
                "cards");

        Interpret();
    }

    public ICollection<Card> Cards { get; }

    public Ranking Ranking { get; private set; }

    public IList<Value> ValuesList { get; private set; }

    public int CompareTo(Hand other)
    {
        if (Ranking > other.Ranking)
        {
            return 1;
        }

        if (Ranking < other.Ranking)
        {
            return -1;
        }

        for (var i = 0; i < ValuesList.Count; i++)
        {
            if (ValuesList[i] > other.ValuesList[i])
            {
                return 1;
            }

            if (ValuesList[i] < other.ValuesList[i])
            {
                return -1;
            }
        }

        return 0;
    }

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
            ValuesList = grouping.Select(g => g.Key).ToList();
        }
        else if (grouping.Count == 3)
        {
            switch (grouping[1].Count())
            {
                case 1:
                    Ranking = Ranking.ThreeOfAKind;
                    ValuesList = new List<Value> { grouping.First().Key };
                    break;
                case 2:
                    Ranking = Ranking.TwoPair;
                    ValuesList = grouping.Select(g => g.Key).ToList();
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
            ValuesList = new List<Value> { grouping.First().Key };
        }
    }

    private void InterpretWhereAllValuesDiffer()
    {
        var isFlush = Cards.Select(c => c.Suit).Distinct().Count() == 1;
        var orderedCards = Cards.OrderByDescending(c => c.Value).ToList();

        var isNormalStraight = ((int) orderedCards[0].Value - (int) orderedCards[4].Value == 4);
        var isLowAceStraight = (orderedCards[1].Value == Value.Five && orderedCards[0].Value == Value.Ace);

        if (isNormalStraight || isLowAceStraight)
        {
            Ranking = isFlush ? Ranking.StraightFlush : Ranking.Straight;
            ValuesList = new List<Value> { isNormalStraight ? orderedCards[0].Value : Value.Five };
        }
        else if (isFlush)
        {
            Ranking = Ranking.Flush;
            ValuesList = orderedCards.Select(x => x.Value).ToList();
        }
        else
        {
            Ranking = Ranking.HighCard;
            ValuesList = orderedCards.Select(x => x.Value).ToList();
        }
    }

    public static Hand Parse(string input)
    {
        return new Hand(input.Split(' ').Select(Card.Parse));
    }
}