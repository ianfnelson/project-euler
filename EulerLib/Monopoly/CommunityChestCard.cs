namespace EulerLib.Monopoly;

public class CommunityChestCard(int cardId) : FortuneCard
{
    public override int GetNextSquare(int currentSquare)
    {
        return cardId switch
        {
            1 => 0,     // Advance to Go
            2 => 10,    // Go to Jail
            _ => currentSquare
        };
    }
}