using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name:Justin FLora
 * Date:7/31/2025
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            // STORAGE
            int number, squared, cubed;
            // INPUT
            if (int.TryParse(NumberBox.Text, out number))
            // PROCESS
            {
                squared = Square(number);
                cubed = Cube(number);
                /* calculate the square of the number and add it to the output - 
                 * do this with a method call that allows you to pass the number
                 * and then receive the answer */

                /* calculate the cube of the number and add it to the output - 
                 * do this by creating a methd as in the squaring example above */

                // OUTPUT
                ResultLabel.Text = $"Square: {squared}  Cube: {cubed}";
                // set the output to visible
                ResultLabel.Visible = true;
                // turn the Go button off
                GoBtn.Enabled = false;
            }
        }

        public int Square(int num)
        {
            // we will create this code in class
            return num * num;
        }

        public int Cube(int num)
        {
            // we will create this code in class
            return num * num * num;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            // the input and output text should be emptied
            NumberBox.Text = "";
            ResultLabel.Text = "";
            // turn the output to invisible
            ResultLabel.Visible = false;
            // turn the Go button back on
            GoBtn.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
