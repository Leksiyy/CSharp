namespace _17_06_24.BookAccounting;

public class Book
{
    public string BookName { get; set; }
    public string AuthorFullName { get; set; } 
    public string ZHANR { get; set; } 
    public DateOnly DATA_VIDANNA { get; set; }

    public override string ToString()
    {
        return $"BookName: {BookName}, AuthorFullName: {AuthorFullName}, ZHANR: {ZHANR}, DATA_VIDANNA: {DATA_VIDANNA}";
    }
}