using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryConversionApplication
{
    public partial class Form1 : Form
    {
        // Custom class coded to validate user inputs
        private BinaryValidator myValidator = new BinaryValidator();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Prepare form / check default values
            this.txtOutputBinary.ReadOnly = true;
            this.radUnsigned.Checked = true;
            this.radDecimalOut.Checked = true;
        }

        
        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Get user input
            string userInput = this.getUserInput();
            

            // Validate the input
            if (myValidator.ValidateUserInput(userInput))
            {
                // Input is valid - continue
                //RawBinaryInput userBinaryInput = new RawBinaryInput(userInput);
                MessageBox.Show("SUCCESS");
            }
            else
            {
                // Input is not valid - stop
                MessageBox.Show("Oops! Please make sure you input either an 8 bit or a 4 bit binary value or, alternatively, a decimal value. Please try again.");
            }
        }

        // Method used to retrieve user input from form
        private string getUserInput()
        {
            string userInput = "";

            try
            {
                userInput = this.txtInputBinary.Text;
            }
            catch (Exception err)
            {
                MessageBox.Show("Oops! " + err.Message + " Please try again.");
            }

            return userInput;
        }
    }
}
