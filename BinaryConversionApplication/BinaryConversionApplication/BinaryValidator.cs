using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryConversionApplication
{
    public class BinaryValidator
    {
        // Method to ensure user has entered valid data
        public bool ValidateUserInput(string input)
        {
            if (input.Length == 8)
            {
                // 8 bit binary input
                return isBinary(input);
            } 
            else if (input.Length == 4)
            {
                // 4 bit binary input
                return isBinary(input);
            }
            else
            {
                // invalid input
                return false;
            }
        }

        // Method to check value input by user is binary (used only in this class)
        private bool isBinary(string input)
        {
            char[] values = input.ToCharArray();

            // Check value is binary
            for (int i = 0; i < values.Length; i++)
            {
                if (!values[i].Equals('0') && !values[i].Equals('1'))
                {
                    // Value is not binary
                    return false;
                }
            }
            // Value is binary
            return true;
        }

        // Method used to ensure decimal value entered can be represented in output type
        public bool runDecimalValidations(int input, string convertingTo)
        {
            switch (convertingTo)
            {
                case "unsigned":

                    if ((input > 255) || (input < 0))
                    {
                        return false;
                    }

                    break;
                case "signed":

                    if ((input > 255) || (input < -127))
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

                    if ((input > 126) || (input < -128))
                    {
                        return false;
                    }

                    break;
            }
            return true;
        }

        // Method used to ensure decimal value entered can be represented in output type
        public bool runFloatValidations(double input, string convertingTo)
        {
            switch (convertingTo)
            {
                case "unsigned":

                    if ((input > 255) || (input < 0))
                    {
                        return false;
                    }

                    break;
                case "signed":

                    if ((input > 255) || (input < -127))
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

                    if ((input > 126) || (input < -128))
                    {
                        return false;
                    }

                    break;
            }
            return true;
        }
    }
}
