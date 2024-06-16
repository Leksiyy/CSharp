namespace _12_06_24.FootballTeam;

public class Player(int playerNumber, bool isFemale)
{
    private int PlayerNumber { set; get; } = playerNumber;
    private bool IsFemale { set; get; } = isFemale;

    public override string ToString()
    {
        return $"Player number: {PlayerNumber}, Is female: {IsFemale}";
    }
}