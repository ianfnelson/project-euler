namespace EulerLib.Monopoly;

public class Game
{
    private readonly int _diceSides;

    private int _doublesCount;

    private readonly Random _random = new();
    
    private readonly Queue<FortuneCard> _communityChestCards = new();
    private readonly Queue<FortuneCard> _chanceCards = new();

    private readonly Dictionary<int, int> _frequencies;

    public Game(int diceSides)
    {
        _diceSides = diceSides;
        
        _frequencies = Enumerable.Range(0,40).ToDictionary(x => x, _ => 0);
        
        Enumerable.Range(1, 16)
            .OrderBy(_ => _random.Next())
            .ToList()
            .ForEach(x => _communityChestCards.Enqueue(new CommunityChestCard(x)));
        
        Enumerable.Range(1, 16)
            .OrderBy(_ => _random.Next())
            .ToList()
            .ForEach(x => _chanceCards.Enqueue(new ChanceCard(x)));
    }

    public Dictionary<int, int> Simulate(int diceRolls)
    {
        var square = 0;

        for (int i = 0; i < diceRolls; i++)
        {
            square = GetNextSquare(square);
            _frequencies[square]++;
        }

        return _frequencies;
    }

    private int GetNextSquare(int currentSquare)
    {
        var d1 = _random.Next(1, _diceSides+1);
        var d2 = _random.Next(1, _diceSides+1);

        // Three doubles -> go to jail
        if (TooManyDoubles(d1, d2))
        {
            return 10;
        }

        currentSquare = (currentSquare + d1 + d2) % 40;

        // Go To Jail square
        if (currentSquare == 30)
        {
            return 10;
        }

        currentSquare = HandleFortuneCards(currentSquare);
        
        return currentSquare;
    }

    private bool TooManyDoubles(int d1, int d2)
    {
        if (d1 == d2)
        {
            _doublesCount++;
        }
        else
        {
            _doublesCount = 0;
        }

        if (_doublesCount != 3) return false;
        
        _doublesCount = 0;
        return true;
    }

    private int HandleFortuneCards(int currentSquare)
    {
        var nextSquare = 
            currentSquare switch
            {
                2 or 17 or 33 => HandleFortuneCards(currentSquare, _communityChestCards),
                7 or 22 or 36 => HandleFortuneCards(currentSquare, _chanceCards),
                _ => currentSquare
            };

        // Handle case where we go back three to another fortune square
        return nextSquare != currentSquare ? HandleFortuneCards(nextSquare) : nextSquare;
    }

    private int HandleFortuneCards(int currentSquare, Queue<FortuneCard> fortuneCardDeck)
    {
        var fortuneCard = fortuneCardDeck.Dequeue();
        var nextSquare = fortuneCard.GetNextSquare(currentSquare);
        fortuneCardDeck.Enqueue(fortuneCard);
        return nextSquare;
    }
}