//Grading Id:A4945
//Dude date: 9/25/2018
//CIS 199-01
//Program 1
//This is a program designed to calculate how many cans of paint you need to paint the walls in a room.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //
            const int SQ_FT_PER_DOOR = 20;
            const int SQ_FT_PER_WINDOW = 15;
            const int SQ_FT_PER_GALLON_OF_PAINT = 350;
            
            //Declaring my Variables:
            double totalLength; //The user will input the total length
            string totalLengthAsAString;//This turns the total length into text
            double heightOfWalls;//The user will input the height of walls
            string heightOfWallsAsAString;//This turns the height of walls into text
            int numberOfDoors;//The user will input the number of doors
            string numberOfDoorsAsAString;//This turns the number of doors into text
            int numberOfWindows;//the user will input the number of windows
            string numberOfWindowsAsAString;//This turns the number of windows into text
            int numberOfPaintCoats;//The user will input the number of paint coats
            string numberOfPaintCoatsAsAString;//this turns the number of paint coats into text
            double minGallons;//This will be the minimum amount of gallons needed to buy.
            int gallonsToBuy;
            //This is the user input
            System.Console.WriteLine("Welcome to the Paint Estimator!");

            System.Console.WriteLine("Enter the total length of all walls (in feet): >>");
            totalLengthAsAString = Console.ReadLine();
            totalLength = double.Parse(totalLengthAsAString);

            System.Console.WriteLine("Enter the height of the walls (in feet): >>");
            heightOfWallsAsAString =Console.ReadLine();
            heightOfWalls = double.Parse(heightOfWallsAsAString);

            System.Console.WriteLine("Enter the number of doors (non-neg int): >>");
            numberOfDoorsAsAString =Console.ReadLine();
            numberOfDoors = int.Parse(numberOfDoorsAsAString);

            System.Console.WriteLine("Enter the number of windows (non-neg int): >>");
            numberOfWindowsAsAString = Console.ReadLine();
            numberOfWindows = int.Parse(numberOfWindowsAsAString);

            System.Console.WriteLine("Enter the number of paint coats (non-neg int): >>");
            numberOfPaintCoatsAsAString = Console.ReadLine();
            numberOfPaintCoats = int.Parse(numberOfPaintCoatsAsAString);

            //The calculations needed to figure out how many paint cans are needed
             minGallons= ((totalLength* heightOfWalls)-(numberOfDoors * SQ_FT_PER_DOOR) - (numberOfWindows * SQ_FT_PER_WINDOW)) * numberOfPaintCoats/SQ_FT_PER_GALLON_OF_PAINT;
            gallonsToBuy= (int)Math.Ceiling(minGallons);

            //This is the ouput
            System.Console.WriteLine($"You will need a minimum of {minGallons} gallons of paint");
            System.Console.WriteLine($"You will need to buy {gallonsToBuy} gallons though ");



         



        }
    }
}
