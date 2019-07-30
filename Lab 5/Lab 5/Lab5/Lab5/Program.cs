//Grading iD:A4945
//Lab 5
//Due Date:10/21
//CIS 199-01
//This lab produces a Star Design.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_ROWS = 10;//This is a constant for the maximum number of rows
            //This program will execute Pattern A.
            Console.WriteLine("Pattern A");
            for (int row = 1; row <= MAX_ROWS; row++)
            {
                for (int star = 1; star <= row; star++)
                    Console.Write("*");
                Console.WriteLine();
            }
            //This program will execute Pattern B.
            Console.WriteLine("Pattern B");
            for (int row = MAX_ROWS; row >= 1; --row)
            {
                for (int star = 1; star <= row; star++)
                    Console.Write("*");
                Console.WriteLine();
            }
            //This program will execute Pattern C.
            Console.WriteLine("Pattern C");
            for (int row = MAX_ROWS; row >= 1; row--)
            { for (int spaces = 1; spaces <= MAX_ROWS-row; spaces++)
                   Console. Write(" ");
                for (int star = 1; star <= row; star++)
                    Console.Write("*");
                Console.WriteLine();
            }
           //This program will execute Pattern D.
            Console.WriteLine("Pattern D");
            for (int row = 1; row<= MAX_ROWS; row++)
            {
                for (int spaces = 1; spaces <= MAX_ROWS - row; spaces++)
                    Console.Write(" ");
                for (int star = 1; star <= row; star++)
                    Console.Write("*");
                Console.WriteLine();
            }

        }
    }

}
    

