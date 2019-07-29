//Grading ID: A4945
//CIS 199-01
//Lab 3
//Due 9/23/2018
// This lab calculates the Sufrace area,volume, and diameter of a sphere.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }
        //This is a picture of the sphere
        private void Picture1_Click(object sender, EventArgs e)
        {

        }
        //This is a picture of the sphere
        private void Picture2_Click(object sender, EventArgs e)
        {

        }
        //Calculate and Display diameter, surfac area, and volume.
        private void calculateButton_Click(object sender, EventArgs e)
        {
           double Radius; //The radius of the sphere.
            double Diameter; // The diameter of the Sphere
            double SurfaceArea; // The surface area of the Sphere
            double Volume;// The volume of the sphere

          
            //Convert input into decimal
            Radius = double.Parse(RadiusAmount.Text);

            //Calculate Diameter, Surface Area, and Volume
            Diameter = Radius * 2;
            SurfaceArea = (4 * Math.PI * Radius)*(Radius*Radius);
            Volume = (4 * Math.PI *Radius*(Radius*Radius))/3;

            //Display Calculations
            outputLbl1.Text= $"{Diameter:F}";
            outputLbl2.Text = $"{SurfaceArea:F}";
            outputLbl3.Text = $"{Volume:F}";
        }





        
    }
}
