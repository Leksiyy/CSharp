using System;
using _07_06_24.BookCheckList;

namespace _07_06_24
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BookList readingList = new BookList();

            Book book1 = new Book("1984", "George Orwell");
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
            Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald");

            readingList += book1;
            readingList += book2;
            readingList += book3;

            Console.WriteLine(readingList.ContainsBook(book1));

            for (int i = 0; i < readingList.BooksCount; i++)
            {
                Book.ShowBook(readingList[i]);
            }

            readingList -= book2;

            Console.WriteLine("Updated reading list:");
            for (int i = 0; i < readingList.BooksCount; i++)
            {
                Book.ShowBook(readingList[i]);
            }

            Console.WriteLine(readingList.ContainsBook(book2));
            
            Console.WriteLine("\n -*-*-*-*-*-*-*-*-*-*-*-*-*-*-*- \n"); //---------//---------//---------//---------//---------//---------
            
            Magazine mag1 = new Magazine(10);
            Magazine mag2 = new Magazine(15);

            Console.WriteLine("mag1: ");
            mag1.ShowMagazine();

            Console.WriteLine("mag2: ");
            mag2.ShowMagazine();

            Console.WriteLine();

            Magazine sumMag = mag1 + 5;
            Console.WriteLine("mag1 + 5:");
            sumMag.ShowMagazine();

            Console.WriteLine();

            Magazine subMag = mag2 - 3;
            Console.WriteLine("mag2 - 3:");
            subMag.ShowMagazine();

            Console.WriteLine();

            Console.WriteLine($"mag1 == mag2: {mag1 == mag2}");
            Console.WriteLine($"mag1 != mag2: {mag1 != mag2}");
            Console.WriteLine($"mag1 < mag2: {mag1 < mag2}");
            Console.WriteLine($"mag1 > mag2: {mag1 > mag2}");

            Console.WriteLine();

            Magazine mag3 = new Magazine(10);
            Console.WriteLine($"mag1.Equals(mag3): {mag1.Equals(mag3)}");
            
            Console.WriteLine("\n -*-*-*-*-*-*-*-*-*-*-*-*-*-*-*- \n"); //---------//---------//---------//---------//---------//---------
            
            Shop shop1 = new Shop(1000);
            Shop shop2 = new Shop(1500);

            Console.WriteLine("Shop 1:");
            shop1.ShowShop();

            Console.WriteLine("Shop 2:");
            shop2.ShowShop();

            Console.WriteLine();

            Shop largerShop = shop1 + 500;
            Console.WriteLine("shop1 + 500:");
            largerShop.ShowShop();

            Console.WriteLine();

            Shop smallerShop = shop2 - 200;
            Console.WriteLine("shop2 - 200:");
            smallerShop.ShowShop();

            Console.WriteLine();

            Console.WriteLine($"shop1 == shop2: {shop1 == shop2}");
            Console.WriteLine($"shop1 != shop2: {shop1 != shop2}");
            Console.WriteLine($"shop1 > shop2: {shop1 > shop2}");
            Console.WriteLine($"shop1 < shop2: {shop1 < shop2}");

            Console.WriteLine();
            
            Shop shop3 = new Shop(1000);
            Console.WriteLine($"shop1.Equals(shop3): {shop1.Equals(shop3)}");
        }
    }
}