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
        // Custom classes coded to validate & convert user inputs
        private BinaryValidator validator = new BinaryValidator();
        private BinaryConverter converter = new BinaryConverter();

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

        // Main method (where all the *magic* happens)
        private void btnConvert_Click(object sender, EventArgs e)
        {
            string userInput = this.getUserInput();

            // Run initial validation
            if (this.runBaseValidations(userInput))
            {
                string validatedBinaryInput;

                // Run further validations
                if (!this.radDecimal.Checked)
                {
                    // Validate the binary input
                    if (validator.ValidateUserInput(userInput))
                    {
                        validatedBinaryInput = userInput;

                        // Get conversion type
                        string[] conversionParamaters = this.getConversionParams();

                        string convertingFrom, convertingTo;

                        convertingFrom = conversionParamaters[0];
                        convertingTo = conversionParamaters[1];

                        // Create new binary object
                        BinaryValue newInput = this.createNewBinary(convertingFrom);
                        newInput.Value = validatedBinaryInput;

                        newInput.Value = this.convertBinaryValue(convertingFrom, convertingTo, newInput.Value);

                        // Output converted value
                        this.txtOutputBinary.Text = newInput.Value;
                    }
                    else
                    {
                        // Input is not valid - stop
                        MessageBox.Show(text: "Oops! Double check your input. Please try again.");
                        this.txtInputBinary.Text = ""; // Reset text field
                    }
                }
                else
                {
                    int userInputValue;

                    // Validate decimal input
                    if (int.TryParse(userInput, out userInputValue))
                    {
                        if ((this.runDecimalValidations(userInputValue)) && (this.isValidNumber(userInputValue)))
                        {
                            // Get conversion type
                            string convertingTo = this.getConvertingTo();

                            // Convert and display binary conversion
                            string output = this.convertDecimalValue(convertingTo, userInputValue);

                            // Output converted value
                            this.txtOutputBinary.Text = output;
                        }
                        else
                        {
                            MessageBox.Show(text: "Make sure your value can be represented in the style you have chosen to output to. Please try again.");
                            this.txtInputBinary.Text = ""; // Reset text field
                        }
                    }
                    else
                    {
                        MessageBox.Show(text: "Oops! Please make sure you input a decimal value. Please try again.");
                        this.txtInputBinary.Text = ""; // Reset text field
                    }
                }
            }
            else
            {
                MessageBox.Show(text: "Oops! Double check your input. Please try again.");
            }
        }

        // Method used to ensure length of user's input complies with representation style chosen
        private bool runBaseValidations(string input)
        {
            if (((this.radSigned.Checked) || (this.radOnesComp.Checked) || (this.radTwosComp.Checked)) && (input.Length == 4))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Method used to ensure user's input complies with representation boundaries
        private bool isValidNumber(int input)
        {
            if ((this.radDecimal.Checked) && (this.radUnsignedOut.Checked) && (input < 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Method used to ensure decimal value entered can be represented in output type
        private bool runDecimalValidations(int input)
        {
            switch (this.getConvertingTo())
            {
                case "unsigned":

                    if ((input > 255) || (input < 0))
                    {
                        return false;
                    }

                    break;
                case "signed":

                    if ((input > 127) || (input < -127))
                    {
                        return false;
                    }

                    break;
                case "ones-complement":

                    if ((input > 127) || (input < -128))
                    {
                        return false;
                    }

                    break;
                case "twos-complement":

                    if ((input > 127) || (input < -128))
                    {
                        return false;
                    }

                    break;
            }
            return true;
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

        // Method to indicate what the user is coverting from & to
        private string[] getConversionParams()
        {
            return new string[] { this.getConvertingFrom(), this.getConvertingTo() };
        }

        // Method to get what the user is converting from
        private string getConvertingFrom()
        {
            if (this.radUnsigned.Checked)
            {
                return "unsigned";
            }
            else if (this.radSigned.Checked)
            {
                return "signed";
            }
            else if (this.radOnesComp.Checked)
            {
                return "ones-complement";
            }
            else
            {
                return "twos-complement";
            }
            
        }

        // Method to get what the user is converting to
        private string getConvertingTo()
        {
            if (this.radUnsignedOut.Checked)
            {
                return "unsigned";
            }
            else if (this.radSignedOut.Checked)
            {
                return "signed";
            }
            else if (this.radOnesOut.Checked)
            {
                return "ones-complement";
            }
            else if (this.radTwosOut.Checked)
            {
                return "twos-complement";
            }
            else
            {
                return "decimal";
            }
        }

        // Method to create a new binary value which can be manipulated
        private BinaryValue createNewBinary(string convertingFrom)
        {
            BinaryValue demoValue = new BinaryValue();

            // Set values of the user's input type
            switch (convertingFrom)
            {
                case "unsigned":
                    demoValue.IsUnsigned = true;
                    break;
                case "signed":
                    demoValue.IsSigned = true;
                    break;
                case "ones-complement":
                    demoValue.IsOnesComplement = true;
                    break;
                case "twos-complement":
                    demoValue.IsTwosComplement = true;
                    break;
            }
            return demoValue;
        }

        // Method to invoke conversion methods and return correct conversion value
        private string convertBinaryValue(string repType, string convertTo, string originalValue)
        {
            string originalBinaryValue = originalValue;
            string convertingFrom = repType;
            string convertingInto = convertTo;

            string convertedValue = "";

            // Determine what the user is comverting to / call correct method
            switch (convertingInto)
            {
                case "unsigned": // CONVERTING TO UNSIGNED BINARY

                    convertedValue = this.converter.ConvertToUnsigned(originalBinaryValue, convertingFrom);

                    break;
                case "signed": // CONVERTING TO SIGNED BINARY

                    convertedValue = this.converter.ConvertToSigned(originalBinaryValue, convertingFrom);

                    break;
                case "ones-complement": // CONVERTING TO ONE'S COMPLEMENT

                    convertedValue = this.converter.ConvertToOnesComplement(originalBinaryValue, convertingFrom);

                    break;
                case "twos-complement": // CONVERTING TO TWO'S COMPLEMENT

                    convertedValue = this.converter.ConvertToTwosComplement(originalBinaryValue, convertingFrom);

                    break;
                case "decimal": // CONVERTING TO DECIMAL

                    convertedValue = this.converter.ConvertToDecimal(originalBinaryValue, convertingFrom);

                    break;
            }
            return convertedValue;
        }

        // Method to invoke conversion from decimal to desired binary representation
        private string convertDecimalValue(string convertingTo, int input)
        {
            string inputInteger = Convert.ToString(input);
            string convertTo = convertingTo;

            string convertedValue = "";

            switch (convertingTo)
            {
                case "unsigned": // CONVERTING TO UNSIGNED BINARY

                    convertedValue = this.converter.ConvertToUnsigned(inputInteger, "decimal");

                    break;
                case "signed": // CONVERTING TO SIGNED BINARY

                    convertedValue = this.converter.ConvertToSigned(inputInteger, "decimal");

                    break;
                case "ones-complement": // CONVERTING TO ONE'S COMPLEMENT

                    convertedValue = this.converter.ConvertToOnesComplement(inputInteger, "decimal");

                    break;
                case "twos-complement": // CONVERTING TO TWO'S COMPLEMENT

                    convertedValue = this.converter.ConvertToTwosComplement(inputInteger, "decimal");

                    break;
                case "decimal": // CONVERTING TO DECIMAL?

                    convertedValue = Convert.ToString(input); // Return same value...

                    break;
            }
            return convertedValue;
        }
    }
}
