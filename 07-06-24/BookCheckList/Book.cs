namespace _07_06_24.BookCheckList
{
    public class Book
    {
        private string Title { get; set; }
        private string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public static bool operator ==(Book book1, Book book2) // сравниваю не объекты а поля потому что так нужно 
        {
            return book1.Author == book2.Author || book1.Title == book2.Title;
        }

        public static bool operator !=(Book book1, Book book2)
        {
            return !(book1.Author != book2.Author && book1.Title != book2.Title);
        }
    }
}