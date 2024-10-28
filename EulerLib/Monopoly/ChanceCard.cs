namespace EulerLib.Monopoly;

public class ChanceCard(int cardId) : FortuneCard
{
    public override int GetNextSquare(int currentSquare)
    {
        return cardId switch
        {
            1 => 0,     // Advance to Go
            2 => 10,    // Go to Jail
            3 => 11,    // Go to C1
            4 => 24,    // Go to E3
            5 => 39,    // Go to H2
            6 => 5,     // Go to R1
            7 or 8 => GetNextRailroad(currentSquare),
            9 => GetNextUtility(currentSquare),
            10 => currentSquare - 3, // Go back three squares (No scenarios where this goes back past GO)
            _ => currentSquare
        };
    }

    private static int GetNextRailroad(int currentSquare)
    {
        return currentSquare switch
        {
            7 => 15,
            22 => 25,
            36 => 5,
            _ => throw new InvalidOperationException()
        };
    }

    private static int GetNextUtility(int currentSquare)
    {
        return currentSquare switch
        {
            7 => 12,
            22 => 28,
            36 => 12,
            _ => throw new InvalidOperationException()
        };
    }
}