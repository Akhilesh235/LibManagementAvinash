using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class User
    {
        private int userID;
        private string userName;
        private List<Book> borrowedBooks;
        private double finePaid;

        public void EnterUserDetails(int ID, string UserName)
        {
            userID = ID;
            userName = UserName;
            finePaid = 0;
            borrowedBooks = new List<Book>();
        }
    }
}


