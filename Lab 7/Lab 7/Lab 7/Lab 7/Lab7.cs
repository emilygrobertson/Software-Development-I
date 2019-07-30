//Grading ID: A4945
//Due: 11/11/2018
//CIS 199-01
//This lab is intended to calculate how much money you need to invest today to earn a certain amount in the future. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class Lab7 : Form
    {
        public Lab7()
        {
            InitializeComponent();
        }
        //Predondition: The user MUST enter a value in each box or else their caluclation will not work properly.
        //This method uses the infoprmation in the previous method to ouput the present value for the user.
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double futurevalue;// The future value
            double interestrate;// The annual interest rate
            int numofyears;//The number of years

            //This will recongize the user's input from the textbox.
            double.TryParse(futureValueTxt.Text, out futurevalue);
            double.TryParse(interestRateTxt.Text, out interestrate);
            int.TryParse(numOfYearsTxt.Text, out numofyears);

            //This calculates and displays the present value for the user.
            outputVLbl.Text= $"{CalcPresentValue(futurevalue, interestrate, numofyears):C}";

        }
        //This method calculates the present value then sends it to the previous method.
        public static double CalcPresentValue(double futurevalue, double interestrate, int numofyears)
        {
            double presentValue;
            presentValue = futurevalue / (Math.Pow(1 + interestrate, numofyears));
            return presentValue;
        }
    }
    
    
}
 