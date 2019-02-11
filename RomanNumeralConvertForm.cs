using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
	

	


namespace RomanNumeralsConverterWFA
{
    public partial class RomanNumeralConvertForm : Form
    {

        private NumberToRoman _convertor = new NumberToRoman();

        public RomanNumeralConvertForm()
        {
            InitializeComponent();
        }


        // Convert the numeral
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            try
            {
                int number;
                if (int.TryParse(NumberInput.Text, out number))
                    ResultLabel.Text = _convertor.numRoman(number);
                else
                    MessageBox.Show("Value must be in the range 1 ~ 1,000,000.");
            }
            catch (Exception)
            {

                MessageBox.Show("Value must be in the range 1 ~ 1,000,000.");
                
                
            }
          
        
        }


        // Exit the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();           
        }


        // View Details of Author and version number
        private void viewDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by:   Jonathan Atkinson \nDate Created:    25/05/2018 \nCreated Using C#", "Revision: 1.1");
        }

  
    }
}
