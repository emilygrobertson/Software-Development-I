//Grading ID:A4945
//CIS 199-01
//Due date: 9/16/18
//Lab 2
//This lab represents a Tip Calculation.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }
        //This event handler will calculate the amount you should tip.
        private void button1_Click(object sender, EventArgs e)
        {
            double num1; //This is the amount of your meal.
            double product1; //This is the tip amount for 15%.
            double product2;//This is the tip amount for 18%.
            double product3;// This is the tip amopunt for 20%.

            num1 = double.Parse(Num1txt.Text);
            product1 = num1 * 0.15;
            Output15.Text = $"{product1}";

            product2 = num1 * 0.18;
            Output18.Text = $"{product2}";
        
            product3 = num1 * 0.20;
            Output20.Text = $"{product3}";

     


         
        }
    }
}