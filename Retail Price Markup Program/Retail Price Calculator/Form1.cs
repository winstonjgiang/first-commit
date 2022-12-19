// Winston Giang

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Create variables
        double wholesaleCost, markupPercent;

        private void CalculateRetail()
        {
            // Create a method named CalculateRetail
            markupPercent *= 0.01;
            wholesaleCost = (markupPercent * wholesaleCost) + wholesaleCost;
            totalRetailPriceLabel.Text = wholesaleCost.ToString("C");
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // If there is a non-numerical value.
            if (double.TryParse(itemCostTextBox.Text, out wholesaleCost) && (double.TryParse(markupTextBox.Text, out markupPercent))) 
            {
                // Use CalculateRetail method
                CalculateRetail();
            }
            else
            {
                MessageBox.Show ("Please enter a valid numerical value");
            }
        }

        private void clearButton_Click(object sender, EventArgs e) 
        {
            // Reset all values on clear button
            wholesaleCost = 0;
            markupPercent = 0;
            double total = 0;
            itemCostTextBox.Text = wholesaleCost.ToString();
            markupTextBox.Text = markupPercent.ToString();
            totalRetailPriceLabel.Text = total.ToString("C");
        }

        private void exitButton_Click(object sender, EventArgs e) 
        {
            // Close the form
            this.Close();
        }
    }
}
