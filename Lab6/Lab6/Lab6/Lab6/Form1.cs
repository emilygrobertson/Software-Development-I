//Grading Id:4945
//CIS 199-01
//Lab 6
//Due Date: 10/28/2018
//This lab will tell a student their grade based on the number of words they typed.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gradeButton_Click(object sender, EventArgs e)
        {   int numOfWords;// user's input
            int[] wordsTypedLowLimits = { 0, 16, 31, 51, 76 };//The lowest number of words typed in a set.
            char [] grade = {'F','D','C','B','A'};//The grades you can recieve for the number of words typed.
            bool found = false;
            char studentGrade = 'F';// If a student doesn't type any words.
            
            int index = wordsTypedLowLimits.Length - 1;//Start from the end since they are limits.


            //This will test the user's input with the grade they should recieve
            if (int.TryParse(wordsTypedTxt.Text, out numOfWords))
            {

                while (index >= 0 && !found)//I used a loop to figure out which grade they will have based on the number of words typed.
                {
                    if (numOfWords >= wordsTypedLowLimits[index])
                        found = true;
                    else
                        --index;
                }
                //States that the student did put a number into the textox.
                if (found)
                    studentGrade = grade[index];
                outputLabel.Text = $"{studentGrade}";
            }
            //The user needs to input a number into the textbox
            else
            MessageBox.Show("Enter the number of words typed:");//This will show the user's letter grade.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
