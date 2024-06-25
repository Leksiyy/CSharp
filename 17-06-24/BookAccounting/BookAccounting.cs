using System.Collections;

namespace _17_06_24.BookAccounting;

public class BookAccounting : IEnumerable<Book>
{
    public LinkedList<Book> _accounting;
    
    public BookAccounting(LinkedList<Book> accounting)
    {
        this._accounting = accounting;
    }

    public BookAccounting()
    {
        _accounting = new LinkedList<Book>();
    }

    public void InsertFirst(Book book)
    {
        _accounting.AddFirst(book);
    }

    public void InsertLast(Book book)
    {
        _accounting.AddLast(book);
    }

    public void InsertByPosition(uint index, Book book)
    {
        LinkedListNode<Book> obj1 = _accounting.First;
        
        for (int i = 0; i < index; i++)
        {
            obj1 = obj1?.Next;
        }

        _accounting.AddBefore(obj1, book);
    }

    public void RemoveFirst()
    {
        _accounting.RemoveFirst();
    }

    public void RemoveLast()
    {
        _accounting.RemoveLast();
    }

    public void RemoveByPosition(uint index)
    {
        LinkedListNode<Book> obj1 = _accounting.First;
        
        for (int i = 0; i < index; i++)
        {
            obj1 = obj1?.Next;
        }

        _accounting.Remove(obj1);
    }

    // BookName
    // AuthorFullName
    // ZHANR 
    // DATA_VIDANNA 
    public bool EditBook(Book book, int[] choose, string[] findOptions)
    {
        var node = _accounting.Find(book);
        if (node == null)
        {
            return false; 
        }

        Book temp = node.Value;

        for (int i = 0; i < choose.Length; i++)
        {
            try
            {
                switch (choose[i])
                {
                    case 0:
                        temp.BookName = findOptions[i];
                        break;
                    case 1:
                        temp.AuthorFullName = findOptions[i];
                        break;
                    case 2:
                        temp.DATA_VIDANNA = DateOnly.Parse(findOptions[i]);
                        break;
                    case 3:
                        temp.ZHANR = findOptions[i];
                        break;
                    default:
                        throw new ArgumentException("Invalid choose index");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating book: {ex.Message}");
                return false;
            }
        }

        return true;
    }

    // BookName
    // AuthorFullName
    // ZHANR 
    // DATA_VIDANNA 
    public List<Book> FindMyBook(int[] choose, Book[] findOptions)
    {
        List<Book> result = new List<Book>();

        if (choose == null || findOptions == null || choose.Length != findOptions.Length)
        {
            return result;
        }

        foreach (Book book in _accounting)
        {
            bool matches = true;
            for (int i = 0; i < choose.Length; i++)
            {
                switch (choose[i])
                {
                    case 0: // BookName
                        if (book.BookName != findOptions[i].BookName)
                        {
                            matches = false;
                        }
                        break;
                    case 1: // AuthorFullName
                        if (book.AuthorFullName != findOptions[i].AuthorFullName)
                        {
                            matches = false;
                        }
                        break;
                    case 2: // ZHANR
                        if (book.ZHANR != findOptions[i].ZHANR)
                        {
                            matches = false;
                        }
                        break;
                    case 3: // DATA_VIDANNA
                        if (book.DATA_VIDANNA != findOptions[i].DATA_VIDANNA)
                        {
                            matches = false;
                        }
                        break;
                    default:
                        matches = false;
                        break;
                }

                if (!matches)
                {
                    break;
                }
            }

            if (matches)
            {
                result.Add(book);
            }
        }

        return result;
    }
    
    public IEnumerator<Book> GetEnumerator()
    {
        return _accounting.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}