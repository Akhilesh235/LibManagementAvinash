using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Library Management System");
            bool loop = true;
            List<Book> BooksInLibrary = new List<Book>();
            while (loop)
            {
                Console.WriteLine("Choose Option Below");
                Console.WriteLine("1. Enter Book Details");
                Console.WriteLine("2. Borrow a book");
                Console.WriteLine("3. Return a book");
                Console.WriteLine("4. Search for a book");
                Console.WriteLine("5. Exit");

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        {
                            Console.WriteLine("\nEnter book details");
                            Book tempbook = new Book();

                            Console.WriteLine("\nEnter Book ID :");
                            int tempID = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Book Name :");
                            string tempBookName = Console.ReadLine();

                            Console.WriteLine("Enter Author Name :");
                            string tempAuthorName = Console.ReadLine();

                            Console.WriteLine("Enter Number of Copies:");
                            int tempNumberOfCopies = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Location of Book:");
                            string tempLocation = Console.ReadLine();

                            tempbook.enterBookDetails(tempID, tempBookName, tempAuthorName, tempNumberOfCopies, tempLocation);

                            //if (BooksInLibrary.Any(x => x.BookId == tempID))
                            //{
                            //    Console.WriteLine("Duplicate Book Details found, Please try again");

                            //}

                            foreach (Book book in BooksInLibrary)
                            {
                                if (book.BookId == tempID)
                                {
                                    Console.WriteLine("Duplicate Book Details found, Please try again");
                                    break;
                                }
                            }





                            BooksInLibrary.Add(tempbook);
                            Console.WriteLine("\nRetrieve Book Details");
                            //tempbook.RetreiveBookDetails();
                            //Console.WriteLine("");
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("User selected to Borrow a book");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("User selected to Return a book");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("User selected to Search a book");


                            Console.WriteLine("\nEnter Book ID :");
                            int tempID = int.Parse(Console.ReadLine());

                            foreach (Book book in BooksInLibrary)
                            {
                                if (book.GetBookID() == tempID)
                                {
                                    Console.WriteLine("\nBook Details Found ");
                                    book.RetreiveBookDetails();
                                    break;
                                }
                            }
                            Console.WriteLine("\nBook does not exist\n");
                            break;
                        }

                    case 5:
                        {
                            loop = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("!!! Invalid Input, Please Try Again !!!!");
                            break;
                        }
                }

            }
        }
    }
}
