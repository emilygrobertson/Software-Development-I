//A4945
//CIS 199-01
//Due date: 12/4
// Program 4


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class TestProgram
    {
        static void Main(string[] args)
        { //Derived Class Objects
          // Pre-Condition: The five Library Books below are the books we will use for this Program
            LibraryBook LibraryBook1 = new LibraryBook("Twilight", "Stephenie Meyer", "Little, Brown and Company", 2005, "00001");
            LibraryBook LibraryBook2 = new LibraryBook("New Moon", "Stephenie Meyer", "Little, Brown and Company", 2006, "00002");
            LibraryBook LibraryBook3 = new LibraryBook("Eclipse", "Stephenie Meyer", "Little, Brown and Company", 2007,"00003");
            LibraryBook LibraryBook4 = new LibraryBook("Breaking Dawn", "Stephenie Meyer", "Little, Brown and Company", 2008,"00004");
            LibraryBook LibraryBook5 = new LibraryBook("To Kill a Mockingbird", "Harper Lee", "J.B. Lippincott & Co.", 1960,"00005");

            // Five element Book Array
            LibraryBook[] books = new LibraryBook[5];

            //initialize array with Employees of derived types
            books[0] = LibraryBook1;
            books[1] = LibraryBook2;
            books[2] = LibraryBook3;
            books[3] = LibraryBook4;
            books[4] = LibraryBook5;


            foreach (LibraryBook currentBook in books)
            {
               Console. WriteLine(currentBook); // invokes ToString implicitly
                Console.WriteLine();

            }
            //Postcondition: End foreach

            //Precondition: Book 1, Book 2, and Book 3 were checked out of the Library
            LibraryBook1.CheckedOut();
            LibraryBook2.CheckedOut();
            LibraryBook3.CheckedOut();
            //Postconditon: none
            
            //Precondition: This loop prints the data to the console
            foreach (LibraryBook currentBook in books)
            {
                Console.WriteLine(currentBook); // invokes ToString implicitly
                Console.WriteLine();

            }
            //Postcondition: The library users need to return the books that were previously checked out.

            //Precondition: The previously checked out books are now being returned.

            LibraryBook1.ReturnToShelf();
            LibraryBook2.ReturnToShelf();
            LibraryBook3.ReturnToShelf();
           //Postcondition: The system is ready for more users to check out books.
        }
    }
}
