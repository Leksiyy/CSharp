namespace _26_06_24;

class Program
{
    static void Main(string[] args)
    {
        VerseGenerics verseCollection = new VerseGenerics();

        Verse verse1 = new Verse
        {
            AuthorFullName = "Alexander Pushkin",
            VerseName = "To A.S.",
            VerseText = "I remember a wonderful moment...",
            VerseTheme = "Love",
            Year = 1825
        };

        Verse verse2 = new Verse
        {
            AuthorFullName = "Mikhail Lermontov",
            VerseName = "The Sail",
            VerseText = "A lonely sail is flashing white...",
            VerseTheme = "Nature",
            Year = 1841
        };

        Verse verse3 = new Verse
        {
            AuthorFullName = "Sergei Yesenin",
            VerseName = "Goodbye",
            VerseText = "Goodbye, my friend, goodbye...",
            VerseTheme = "Farewell",
            Year = 1925
        };

        verseCollection.Add(verse1);
        verseCollection.Add(verse2);
        verseCollection.Add(verse3);

        verseCollection.Remove(1);

        Verse editedVerse = new Verse
        {
            AuthorFullName = "Sergei Yesenin",
            VerseName = "Goodbye",
            VerseText = "Goodbye, my friend, goodbye...",
            VerseTheme = "Farewell",
            Year = 1926 // Изменен год
        };
        verseCollection.EditVerse(editedVerse, 1);

        Verse searchVerse = new Verse
        {
            AuthorFullName = "Sergei Yesenin",
            VerseName = "Goodbye",
            VerseText = "Goodbye, my friend, goodbye...",
            VerseTheme = "Farewell",
            Year = 1926
        };

        Verse? foundVerse = verseCollection.FindVerse(searchVerse);
        if (foundVerse != null)
        {
            Console.WriteLine("Found Verse:");
            foundVerse.Display();
        }
        else
        {
            Console.WriteLine("Verse not found.");
        }

        verseCollection.SaveVersesInfo();
        Console.WriteLine("Verses saved to file.");

        List<Verse> loadedVerses = verseCollection.LoadVersesInfo();
        Console.WriteLine("Verses loaded from file:");
        foreach (var verse in loadedVerses)
        {
            verse.Display();
        }
    }
}