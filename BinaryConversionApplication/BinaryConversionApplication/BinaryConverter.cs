using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionApplication
{
    public class BinaryConverter
    {
        // Method to convert user input into an unsigned binary number
        public string ConvertToUnsigned(string input)
        {
            return "";
        }

        // Method to convert user input into a signed binary number
        public string ConvertToSigned(string input)
        {
            return "";
        }

        // Method to convert user input into a one's complement binary number
        public string ConvertToOnesComplement(string input)
        {
            char[] binaryValue = input.ToCharArray();

            for (int i = 0; i < binaryValue.Length; i++)
            {
                if (binaryValue[i].Equals('0'))
                {
                    binaryValue[i] = '1';
                }
                else
                {
                    binaryValue[i] = '0';
                }
            }

            return binaryValue.ToString();
        }

        // Method to convert user input into a two's complement binary number
        public string ConvertToTwosComplement(string input)
        {
            return "";
        }

        // Method to convert user input into a decimal number
        public string ConvertToDecimal(string input)
        {
            return "";
        }
    }
}
