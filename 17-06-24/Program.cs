using _17_06_24.BookAccounting;

namespace _17_06_24;

class Program
{
    static void Main(string[] args)
    {
        CoWorker coWorker1 = new CoWorker("Just Adam", "Manager", 17000, "JustAdamManager@inc.com");
        CoWorker coWorker2 = new CoWorker("Just Linda", "Worker", 15000, "Mi$$LindA@inc.com");
        CoWorker coWorker3 = new CoWorker("Mister Maximilian", "Seller", 16500, "ImNotSelfish!!!@inc.com");
        CoWorker coWorker4 = new CoWorker("Joe Biden", "Advertisement Manager", 20000, "IM_NOT_SELLER@inc.com");
        CoWorker coWorker5 = new CoWorker("Marcus Smith", "Designer", 175000, "pro_killer2003@inc.com");

        Accounting accounting = new Accounting(coWorker1, coWorker2, coWorker3, coWorker4);
        
        accounting.AddCoWorker(coWorker5);

        foreach (CoWorker coWorker in accounting)
        {
            Console.WriteLine(coWorker);
        }
        
        Console.WriteLine('\n');

        // fix salary from 175 000 to 17 500
        CoWorker editedCoWorker = new CoWorker("Marcus Smith", "Designer", 17500, "pro_killer2003@inc.com");
        accounting.EditCoWorker(coWorker5, editedCoWorker);

        // console out salary fix
        Console.WriteLine(accounting.FindCoWorker([2], ["17500"])[0].FullName + " " + accounting.FindCoWorker([2], ["17500"])[0].Salary);

        Console.WriteLine('\n');
        
        // sort by Salary
        foreach (CoWorker coWorker in accounting.SortCoWorkers(2)) // returns list
        {
            Console.WriteLine(coWorker);
        }
        
        Console.WriteLine('\n');
        
        // remove CoWorker
        accounting.RemoveCoWorker(accounting.FindCoWorker([2], ["17500"])[0]);
        
        foreach (CoWorker coWorker in accounting)
        {
            Console.WriteLine(coWorker);
        }
        
        Console.WriteLine("\n ----------------------------- \n");
        
        var books = new LinkedList<Book>(new List<Book>
        {
            new Book
            {
                BookName = "The Great Gatsby",
                AuthorFullName = "F. Scott Fitzgerald",
                ZHANR = "Classic",
                DATA_VIDANNA = new DateOnly(1925, 4, 10)
            },
            new Book
            {
                BookName = "To Kill a Mockingbird",
                AuthorFullName = "Harper Lee",
                ZHANR = "Fiction",
                DATA_VIDANNA = new DateOnly(1960, 7, 11)
            },
            new Book
            {
                BookName = "1984",
                AuthorFullName = "George Orwell",
                ZHANR = "Dystopian",
                DATA_VIDANNA = new DateOnly(1949, 6, 8)
            },
            new Book
            {
                BookName = "Moby-Dick",
                AuthorFullName = "Herman Melville",
                ZHANR = "Adventure",
                DATA_VIDANNA = new DateOnly(1851, 10, 18)
            },
        });

        BookAccounting.BookAccounting bookAccounting = new BookAccounting.BookAccounting(books);
        
        foreach (Book book in bookAccounting)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine('\n');

        // Testing methods
        bookAccounting.InsertFirst(new Book
        {
            BookName = "Brave New World",
            AuthorFullName = "Aldous Huxley",
            ZHANR = "Dystopian",
            DATA_VIDANNA = new DateOnly(1932, 8, 18)
        });
        bookAccounting.InsertLast(new Book
        {
            BookName = "Pride and Prejudice",
            AuthorFullName = "Jane Austen",
            ZHANR = "Romance",
            DATA_VIDANNA = new DateOnly(1813, 1, 28)
        });
        bookAccounting.InsertByPosition(0, new Book // first too
        {
            BookName = "Moby-Dick",
            AuthorFullName = "Herman Melville",
            ZHANR = "Adventure",
            DATA_VIDANNA = new DateOnly(1851, 10, 18)
        });
        foreach (Book book in bookAccounting)
        {
            Console.WriteLine(book);
        }
        
        var choose = new[] { 0, 1 };
        List<Book> foundBooks = bookAccounting.FindMyBook(choose, new Book[] 
        {
            new Book { BookName = "1984" },
            new Book { AuthorFullName = "George Orwell" }
        });
        
        Console.WriteLine('\n');
        foreach (Book book in foundBooks)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine($"Found {foundBooks.Count} books matching criteria.");
        Console.WriteLine('\n');

        var editBook = foundBooks[0];
        
        bool edited = bookAccounting.EditBook(editBook, [3], ["Political Fiction"]);
        
        Console.WriteLine(edited ? "Book edited successfully." : "Failed to edit book.");
        
        List<Book> foundBooks1 = bookAccounting.FindMyBook(choose, new Book[] 
        {
            new Book { BookName = "1984" },
            new Book { AuthorFullName = "George Orwell" }
        });
        Console.WriteLine(foundBooks1[0]);
    }
}
