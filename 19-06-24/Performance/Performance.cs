namespace _19_06_24.Performance;

class Performance(string title, string theater, string genre, int duration, List<string> actors)
    : IDisposable
{
    public string Title { get; set; } = title;
    public string Theater { get; set; } = theater;
    public string Genre { get; set; } = genre;
    public int Duration { get; set; } = duration;
    public List<string> Actors { get; set; } = actors;

    public void DisplayInfo()
    {
        Console.WriteLine("Назва спектаклю: " + Title);
        Console.WriteLine("Назва театру: " + Theater);
        Console.WriteLine("Жанр: " + Genre);
        Console.WriteLine("Тривалість: " + Duration + " хвилин");
        Console.WriteLine("Список акторів: " + string.Join(", ", Actors));
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
        Console.WriteLine("Вистава \"{0}\" була видалена", Title);
    }
    
    ~Performance()
    {
        Dispose();
    }
}
