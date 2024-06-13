using System;

namespace _07_06_24.BookCheckList
{
    public class Book
    {
        private string Title { get; set; }
        private string Author { get; set; }

        public Book(string title, string author)
        {
            if (title == null)
            {
                Title = "";
            }
            Title = title;
            if (author == null)
            {
                Author = "";
            }
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

        public static void ShowBook(Book book)
        { 
            System.Console.Out.WriteLine("Title:" + book.Title + ". Author: " + book.Author + ".\n");
        }
    }
}