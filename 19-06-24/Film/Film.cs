namespace _19_06_24.Film;

using System;

class Film(string title, string studio, string genre, int duration, int year)
    : IDisposable
{
    public string Title { get; set; } = title;
    public string Studio { get; set; } = studio;
    public string Genre { get; set; } = genre;
    public int Duration { get; set; } = duration;
    public int Year { get; set; } = year;

    public void DisplayInfo()
    {
        Console.WriteLine("Назва фільму: " + Title);
        Console.WriteLine("Кіностудія: " + Studio);
        Console.WriteLine("Жанр: " + Genre);
        Console.WriteLine("Тривалість: " + Duration + " хвилин");
        Console.WriteLine("Рік: " + Year);
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
        Console.WriteLine("Фільм \"{0}\" було видалено", Title);
    }

    ~Film()
    {
        Dispose();
    }
}