// A4945
//Program 4
//Due date: 12/4/2018
//CIS 199-01
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    public class LibraryBook
    { // Setting the Backing Fields
        private string _title;
        private string _author;
        private string _publisher;
        private int _copyrightYear;
        private string _callnumber;

        //5-parameter contstructor
        public LibraryBook (string title, string author, string publisher, int copyrightYear, string callNumber)
        {  
            Title = title;
            Author = author;
            Publisher = publisher;
            CopyrightYear = copyrightYear;
            CallNumber = callNumber;
        }
        //string property for Title
        public string Title
        {
            get
            { return _title; }
            set
            { _title = value; }
        }
        //string property for Author
        public string Author
        {
            get
            { return _author; }
            set
            { _author = value; }
        }
        //string property for publisher
        public string Publisher
        {
            get
            { return _publisher; }
            set
            { _publisher = value; }
        }

        //string property for copyright year
        public int CopyrightYear
        {
            get
            { return _copyrightYear; }
            set
            {
                if (value >= 0)
                    _copyrightYear = value;
                else
                    _copyrightYear = 2018;
            }
        }

        //property string for call number
        public string CallNumber
        {
            get
            { return _callnumber; }
            set
            { _callnumber = value; }
        }
        bool BookCheckedOut = false;
        //Method for book's checked out status
        public void CheckedOut()
        {
            BookCheckedOut = true;
        }
        //Method for book's return to shelf status
        public void ReturnToShelf()
        {
            BookCheckedOut = false;
        }
        // Precondition: Method that returns true if book is checked out and false if it isn't 
        public bool IsCheckedOut()
        {
            bool isCheckedOut;
            if (BookCheckedOut)
            {
                isCheckedOut = true;
            }
            else
                isCheckedOut = false;
            return isCheckedOut;
        }
        //Postcondition: This method will help the user know if the book is checked out

        // Precondition: This method will return a string for all of the information about a book
        public override string ToString()
        {
         return $"The Title is {Title}" + $"{Environment.NewLine} The Author is {Author}" + $"{Environment.NewLine} The Publisher is {Publisher}" + $"{Environment.NewLine} The Copyright Year is {CopyrightYear}" + $"{Environment.NewLine} The CallNumber is {CallNumber}" + $"{Environment.NewLine} Checked Out? {BookCheckedOut}";
        }
    }
    // Postcondition: This method will show the output for the user.
    
}

