//Grading ID: A4945
//Lab 4
//CIS 199-01
//Due date: October 3rd 2018
// This lab uses a user's GPA and test score to see if they were accepted or rejected.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {private int runningTotal=0;//This is assigning a value to the running total.
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double GPA;//This is the GPA that the user should input
            double testScore;//This is the test score that the user should input.

            //This is the if statement that will see if there is a valid test score and GPA.
            if (double.TryParse(GPAText.Text, out GPA)&& double.TryParse(testScoreText.Text, out testScore ))
            { if ((GPA >= 3.0 && testScore >= 60) || (GPA < 3.0 && testScore >= 80))
                    MessageBox.Show("Accept");
                else
                    MessageBox.Show("Reject");
                ++runningTotal;

                totalLbl.Text = $"{runningTotal}";
            }
            else
                MessageBox.Show("Enter your GPA and Test Score");
        }
    }
}
