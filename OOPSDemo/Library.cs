using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSDemo
{
    internal class Library : IBorrowable
    {
        private List<Books> booklist = new List<Books>();
        public void AddBook(Books book)
        {
            booklist.Add(book);
            Console.WriteLine($"Book'{book.Title}' added to the library");
        }

        public void DisplayBooks()
        {
            if (booklist.Count == 0)
            {
                Console.WriteLine("No books in library");
            }
            else
            {
                foreach (var book in booklist)
                {
                    book.DisplayInfo();

                }

            }
        }
        public void Borrow()
        {
            Console.WriteLine("Boorowing from library directly is not allowed");

        }
        public void Return()
        {
            Console.WriteLine("Returning from Library directly is not allowed");
        }

    }
}
