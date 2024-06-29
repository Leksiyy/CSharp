namespace _19_06_24;

class Program
{
    static void Main(string[] args)
    {
        using (Film.Film myFilm = new Film.Film("False Mirror", "netflix", "Horror", 120, 2023))
        {
            myFilm.DisplayInfo();
        }
        
        Console.WriteLine("\n ////////////////// \n");
        
        List<string> actors = new List<string> { "Actor 1", "Actor 2", "Actor 3" };

        using (Performance.Performance myPerformance = new Performance.Performance("be or not to be", "Lviv opera", "lyric", 150, actors))
        {
            myPerformance.DisplayInfo();
        }
    }
}