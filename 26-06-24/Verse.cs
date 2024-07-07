namespace _26_06_24;

public class Verse
{
    public string? VerseName;
    public string? AuthorFullName;
    public ushort? Year;
    public string? VerseText;
    public string? VerseTheme;

    public Verse(string? verseName, string? authorFullName, ushort? year, string? verseText, string? verseTheme)
    {
        VerseName = verseName;
        AuthorFullName = authorFullName;
        Year = year;
        VerseText = verseText;
        VerseTheme = verseTheme;
    }

    public Verse()
    {
        
    }

    public override string ToString()
    {
        return VerseName + "џ" + AuthorFullName + "џ" + Year + "џ" + VerseText + "џ" + VerseTheme;
    }

    public void Display()
    {
        Console.WriteLine($"{VerseName}, {AuthorFullName}, {Year}, {VerseText}, {VerseTheme}");
    }
}