namespace _10_06_24;

public class Book(string? title, string? author)
{
    private string Title { get; } = title ?? "";
    private string Author { get; } = author ?? "";

    public static bool operator ==(Book book1, Book book2) // сравниваю не объекты а поля потому что так нужно 
    {
        return book1.Author == book2.Author || book1.Title == book2.Title;
    }

    public static bool operator !=(Book book1, Book book2)
    {
        return !(book1.Author != book2.Author && book1.Title != book2.Title);
    }

    public static void ShowBook(Book book)
    {
        Console.Out.WriteLine("Title:" + book.Title + ". Author: " + book.Author + ".\n");
    }
}