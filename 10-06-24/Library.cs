using System.Collections;

namespace _10_06_24;

public class Library
{
    private List<Book> _library;

    public Library(params Book[] books)
    {
        _library = new List<Book>(books);
    }

    public void AddBook(Book book)
    {
        if (!_library.Contains(book))
        {
            _library.Add(book);
        }
    }
    
    public bool RemoveBook(Book book)
    {
        return _library.Remove(book);
    }
    
    public IEnumerator<Book> GetEnumerator()
    {
        foreach (Book book in _library)
        {
            yield return book;
        }
    }
}