namespace _10_06_24;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("1984", "George Orwell");
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
        Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald");

        Library lib = new Library([book1, book2, book3]);

        foreach (Book book in lib)
        {
            Console.WriteLine(book);
        }
    }
}