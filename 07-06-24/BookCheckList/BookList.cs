using System;
using System.Collections.Generic;

namespace _07_06_24.BookCheckList
{
    public class BookList
    {
        private List<Book> Books = new List<Book>();

        public int BooksCount =>
            Books.Count; //лябмда выражение. при каждом обрщении к переменной буду иметь акктуальную информацию

        public Book this[int i]
        {
            get
            {
                if (i < 0 || i >= BooksCount)
                {
                    throw new IndexOutOfRangeException("Index out of ");
                }

                return Books[i];
            }
            set
            {
                if (i < 0 || i >= BooksCount)
                {
                    throw new IndexOutOfRangeException("Index out of ");
                }

                Books[i] = value;
            }
        }

        public void AddBook(Book book)
        {
            if (!Books.Contains(book))
            {
                Books.Add(book);
            }
        }

        public bool RemoveBook(Book book)
        {
            return Books.Remove(book);
        }

        public bool ContainsBook(Book book)
        {
            return Books.Contains(book);
        }

        public static BookList operator +(BookList list, Book book)
        {
            list.AddBook(book);
            return list;
        }
        
        public static BookList operator -(BookList list, Book book)
        {
            list.RemoveBook(book);
            return list;
        }
    }
}