using _12_06_24.Cafe;
using _12_06_24.FootballTeam;

namespace _12_06_24;

class Program
{
    static void Main(string[] args)
    {
        Oceanarium oceanarium =
            new Oceanarium(new Herring(5, 30),new Shrimps(2, 12),new Jellyfish(5, 2));

        foreach (object o in oceanarium)
        {
            Console.WriteLine(o);
        }

        Console.WriteLine("\n");
        
        FootballTeam.FootballTeam team =
            new FootballTeam.FootballTeam(new Player(1, false), new Player(2, false), new Player(3, true));

        foreach (Player pl in team)
        {
            Console.WriteLine(pl);
        }
        
        Console.WriteLine("\n");

        Cafe.Cafe cafe = new Cafe.Cafe(new Worker(15000, "Anya"), new Worker(13500, "Frank"));

        foreach (Worker w in cafe)
        {
            Console.WriteLine(w);
        }
    }
}