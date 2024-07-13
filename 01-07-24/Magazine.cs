using System.Net.Http.Json;
using System.Text.Json;

namespace _01_07_24;

public class Magazine(string? magazineName, string? publishingHouseName, DateTime? publicationDate, uint? numberOfPages)
{
    public string? MagazineName { get; set; } = magazineName;
    public string? PublishingHouseName { get; set; } = publishingHouseName;
    public DateTime? PublicationDate { get; set; } = publicationDate;
    public uint? NumberOfPages { get; set; } = numberOfPages;

    private const string? PATH = "../../../privet.json";

    public void InputInfo(int[] index, string[] info)
    {
        if (index.Length > 4)
        {
            throw new ArgumentException("InputInfo first argument must have less than 5 elements ");
        }
        
        if (info.Length > 4)
        {
            throw new ArgumentException("InputInfo second argument must have less than 5 elements");
        }

        for (int i = 0; i < index.Length; i++)
        {
            switch (index[i])
            {
                case 0:
                    this.MagazineName = info[i];
                    break;
                case 1:
                    this.PublishingHouseName = info[i];
                    break;
                case 2:
                    this.PublicationDate = DateTime.Parse(info[i]);
                    break;
                case 3:
                    this.NumberOfPages = uint.Parse(info[i]);
                    break;
            }
        }
    }

    public void OutputInfo()
    {
        Console.WriteLine($"Name of this magazine is: {MagazineName}," +
                          $" publishing house of this magazine is: {PublishingHouseName}," +
                          $" publication date of magazine is: {PublicationDate}," +
                          $" number of pages of magazine is: {NumberOfPages}.");
    }

    private string Serealize()
    {
        string jsonStr = JsonSerializer.Serialize(this);
        if (jsonStr.Length > 0)
        {
            return jsonStr;
        }

        throw new Exception("Cannot serialize this object.");
    }

    public void SaveJsonToFile()
    {
        try
        {
            string json = this.Serealize();
            File.WriteAllText(PATH, json);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void LoadJsonFromFile()
    {
        string jsonFromFile = File.ReadAllText(PATH);
        if (jsonFromFile.Length > 0)
        {
            var data = JsonSerializer.Deserialize<Magazine>(jsonFromFile);
            this.MagazineName = data.MagazineName;
            this.PublicationDate = data.PublicationDate;
            this.NumberOfPages = data.NumberOfPages;
            this.PublishingHouseName = data.PublishingHouseName;
        }
        else
        {
            Console.WriteLine("File is empty");
        }
    }
}