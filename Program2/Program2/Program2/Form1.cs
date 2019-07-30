//Grading Code: A4945
//Program 2
//Due Date:10/18/2018
//CIS 199-01
//This is a program to determine when a student should register for classes.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lastNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string TIME1 = "8:30";//The first time to register.
            const string TIME2 = "10:00";//The second time to register.
            const string TIME3 = "11:30";//The third time to register.
            const string TIME4 = "2:00";//The fourth time to register.
            const string TIME5 = " 4:00";//The last time to register.

            const string DAY1 = "11 / 2";//The day for Seniors to register.
            const string DAY2 = "11 / 5";//The day for juniors to register.
            const string DAY3 = "11 / 6";//The first day for sophomores to register.
            const string DAY4 = "11 / 7";//The second day for sophomores to register.
            const string DAY5 = "11 / 8";//The first day for freshman to register.
            const string DAY6 = "11 / 9";//The second day for freshman to register


            string day = "";//This is used to figure out which day the student registers on.
            string time = "";//This is used to figure out what time the student will register.
            char ch = Convert.ToChar(lastNameTxt.Text);
            ch = char.ToUpper(ch);
            if (char.IsLetter(ch))
                //This calculates the day for each student.
            {
                if (seniorButton.Checked)
                    day = DAY1;

                else if (juniorButton.Checked)
                    day = DAY2;
                else if (sophomoreButton.Checked)
                {
                    if (ch >= 'E' && ch <= 'Q')
                        day = DAY3;
                    else
                        day = DAY4;
                }
                else if (freshmanButton.Checked)
                {
                    if (ch >= 'E' && ch <= 'Q')
                        day = DAY5;
                    else
                        day = DAY6;
                }
                //This calculates the time for each student.
                if (seniorButton.Checked || juniorButton.Checked)
                {
                    if (ch <= 'D')
                        time = TIME5;
                    else if (ch <= 'I')
                        time = TIME1;
                    else if (ch <= 'O')
                        time = TIME2;
                    else if (ch <= 'S')
                        time = TIME3;
                    else
                        time = TIME4;
                }

                if (sophomoreButton.Checked || freshmanButton.Checked)
                {
                    if (ch <= 'R' && ch <= 'S' || ch <= 'E' && ch <= 'F')
                        time = TIME1;
                    else if (ch <= 'G' && ch <= 'I' || ch <= 'T' && ch <= 'V')
                        time = TIME2;
                    else if (ch <= 'J' && ch <= 'L' || ch <= 'W' && ch <= 'Z')
                        time = TIME3;
                    else if (ch <= 'A' && ch <= 'B' || ch <= 'M' && ch <= 'O')
                        time = TIME4;
                    else
                        time = TIME5;
                }
                //This will show the student when they are supposed to register.
                MessageBox.Show($"The date you will register is {day} at {time}");


            }
        }
    }
}
  
    
       

        
    
