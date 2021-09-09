using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreOperation
{
    //struct Books
    //{
    //    public string bookTitle;
    //    public string bookAuthor;
    //    public string bookSubject;
    //};
   public class BookOperation
    {
        static void Main(string[] args)
        {
            //declaring books of type Books
            Books book1;
            Books book2;

            //assigning values assorted data types in the struct
            book1.bookTitle = "The Alchemist";
            book1.bookAuthor = "Paulo Coelho";
            book1.bookSubject = "Fantasy";

            book2.bookTitle = "Basics of Computer Organization";
            book2.bookAuthor = "Carl Hamacher";
            book2.bookSubject = "Computer Organization";

            //accessing the struct elements
            Console.WriteLine("Book1 Title: {0}",  book1.bookTitle);
            Console.WriteLine("Book1 Author: {0}", book1.bookAuthor);
            Console.WriteLine("Book1 Subject: {0}", book1.bookSubject);

            Console.WriteLine("\n");

            Console.WriteLine("Book1 Title: {0}", book2.bookTitle);
            Console.WriteLine("Book1 Author: {0}", book2.bookAuthor);
            Console.WriteLine("Book1 Subject: {0}", book2.bookSubject);
            Console.ReadLine();

        }
    }
}
