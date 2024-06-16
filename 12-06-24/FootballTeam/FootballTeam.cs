namespace _12_06_24.FootballTeam;

public class FootballTeam(params Player[] list)
{
    private List<Player> _list = [..list];

    public IEnumerator<Player> GetEnumerator()
    {
        foreach (Player player in _list)
        {
            yield return player;
        }
    }
}