namespace _26_06_24;

public class VerseGenerics
{
    public List<Verse> list = new List<Verse>();

    public void Add(Verse verse)
    {
        list.Add(verse);
    }

    public void Remove(int i)
    {
        list.RemoveAt(i);
    }

    public void EditVerse(Verse verse, int i)
    {
        list[i] = verse;
    }

    public Verse? FindVerse(Verse verse) // система рейтингов, у кого больше баллов совпадения - тот и возвращаеться.
    {
        Verse? result = null;
        int resultRating = 0;
        foreach (Verse verse1 in list)
        {
            int tempRating = 0;
            if (verse1.VerseName == verse.VerseName)
            {
                tempRating++;
            }
            if (verse1.VerseText == verse.VerseText)
            {
                tempRating++;
            }
            if (verse1.VerseTheme == verse.VerseTheme)
            {
                tempRating++;
            }
            if (verse1.Year == verse.Year)
            {
                tempRating++;
            }
            if (verse1.AuthorFullName == verse.AuthorFullName)
            {
                tempRating++;
            }
            if (tempRating == 5) return verse1;
            if (tempRating > resultRating) result = verse1;
        }

        return result;
    }

    public void SaveVersesInfo()
    {
        var line = list.Select(verse => verse.ToString());
        File.WriteAllLines("./text", line);
    }

    public List<Verse> LoadVersesInfo()
    {
        var lines = File.ReadAllLines("./text");
        List<Verse> result = new List<Verse>();
        foreach (string line in lines)
        {
            string[] parts = line.Split("џ");
            if (parts.Length != 5)
            {
                throw new FormatException("Invalid string format for Verse");
            }

            result.Add(new Verse
            {
                VerseName = parts[0],
                AuthorFullName = parts[1],
                Year = ushort.Parse(parts[2]),
                VerseText = parts[3],
                VerseTheme = parts[4],
            });
        }

        return result;
    }
}