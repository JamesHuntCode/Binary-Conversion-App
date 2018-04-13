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
        public bool ValidateUserInput(string input, bool isFloat)
        {
            if (!isFloat)
            {
                if ((input.Length == 8) || (input.Length == 4))
                {
                    return isBinary(input, isFloat);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if ((input.Length > 0) && (input.Length < 17))
                {
                    return isBinary(input, isFloat);
                }
                else
                {
                    return false;
                }
            }
        }

        // Method to check value input by user is binary (used only in this class)
        private bool isBinary(string input, bool isFloat)
        {
            char[] values = input.ToCharArray();

            if (!isFloat)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    if (!values[i].Equals('0') && !values[i].Equals('1'))
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < values.Length; i++)
                {
                    if ((!values[i].Equals('0')) && (!values[i].Equals('1')) && (!values[i].Equals('.')))
                    {
                        return false;
                    }
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
