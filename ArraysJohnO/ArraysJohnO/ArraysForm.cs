using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysJohnO
{
    public partial class frmArrayAverage : Form
    {
        // declare global variables and constants
        const int MAX_ARRAY_SIZE = 10;
        int[] arrayOfNumbers = new int[MAX_ARRAY_SIZE];

        public frmArrayAverage()
        {
            InitializeComponent();
            // hide label
            lblAnswer.Hide();

            // disable buttons
            btnCalculate.Enabled = false;
        }

        private void frmArrayAverage_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            int randomNumber;
            int counter;
            Random randomNumberGenerator = new Random();

            // Enable buttons
            btnCalculate.Enabled = true;

            // Clear list box
            this.lstNumbers.Items.Clear();

            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                // generate a new random number between 1 and the max array size
                randomNumber = randomNumberGenerator.Next(1, MAX_ARRAY_SIZE + 1);

                // assign the random number to the cell at position counter in the array
                arrayOfNumbers[counter] = randomNumber;

                // Display list
                this.lstNumbers.Items.Add(randomNumber);

                // refresh the form to display the new item in the list box
                this.Refresh();
            }
        }

        private void lstNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double average = 0;
            double sum = 0;
            int counter;

            // Show label
            lblAnswer.Show();

            // calculate the sum of all the values in the array 
            for (counter = 0; counter < arrayOfNumbers.Length; counter++)
            {
                sum = sum + arrayOfNumbers[counter];
            }

            // calculate the average of the values in the array 
            average = sum / arrayOfNumbers.Length;

            // display the average in the label
            lblAnswer.Text = "Average: " + average;
        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
