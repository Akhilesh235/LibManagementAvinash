using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class Book
    {
        private int bookId;
        private string bookName;
        private string author;
        private int numberOfCopies;
        private string location;


        //public int BookId
        //{
        //    get => bookId;
        //    set { bookId = value; }
        //}

        public void enterBookDetails(int Id, string name, string Author, int noOfCopies, string Location)
        {
            bookId = Id;
            bookName = name;
            author = Author;
            numberOfCopies = noOfCopies;
            location = Location;
        }


        public void RetreiveBookDetails()
        {
            Console.WriteLine("Book ID : " + bookId);
            Console.WriteLine("Title of Book : " + bookName);
            Console.WriteLine("Author : " + author);
            Console.WriteLine("Number of Copies: " + numberOfCopies);
            Console.WriteLine("Location of Book : " + location);
        }

        public int GetBookID()
        {
            return bookId;
        }


    }
}
