namespace _12_06_24.Cafe;

public class Cafe (params Worker[] list)
{
    private List<Worker> _list = [..list];

    public IEnumerator<Worker> GetEnumerator()
    {
        foreach (Worker worker in _list)
        {
            yield return worker;
        }
    }
}