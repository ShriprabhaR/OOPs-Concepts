using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSDemo
{
    internal class Books : Item, IBorrowable
    {
        public String author {  get; set; }
        public String isbn;
        public String ISBN
        {
            get => isbn;
            set => isbn = value;
        }
        public bool IsBorrowed {  get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Title:{Title}, Author:{author}, ISBN:{ISBN}");
        }

        public void Borrow()
        {
            if (IsBorrowed)
            {
                Console.WriteLine("The book is already Borrowed");
            }
            else
            {
                IsBorrowed = true;
                Console.WriteLine("The book has been borrowed");
            }

        }
        public void Return()
        {
            if (IsBorrowed)
            {
                IsBorrowed= false;
                Console.WriteLine("The book has been Returned");
            }
            else
            { }
                Console.WriteLine("The book was not borrowed");
            }

        }
    }

