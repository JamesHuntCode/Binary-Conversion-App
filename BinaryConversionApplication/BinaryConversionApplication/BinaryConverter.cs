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
        public string ConvertToUnsigned(string input, string repType)
        {
            return "";
        }

        // Method to convert user input into a signed binary number
        public string ConvertToSigned(string input, string repType)
        {
            return "";
        }

        // Method to convert user input into a one's complement binary number
        public string ConvertToOnesComplement(string input, string repType)
        { 
            string convertedValue = "";

            switch (repType)
            {
                case "unsigned":

                    convertedValue = this.fromUnsignedToOnesComplement(input);

                    break;
                case "signed":



                    break;
                case "ones-complement":

                    convertedValue = input;

                    break;
                case "twos-complement":



                    break;
                case "decimal":



                    break;
            }

            return convertedValue;
        }

        // Method to convert user input into a two's complement binary number
        public string ConvertToTwosComplement(string input, string repType)
        {
            return "";
        }

        // Method to convert user input into a decimal number
        public string ConvertToDecimal(string input, string repType)
        {
            string convertedValue = "";

            switch (repType)
            {
                case "unsigned":

                    break;
                case "signed":

                    break;
                case "ones-complement":

                    break;
                case "twos-complement":

                    break;
            }

            return convertedValue;
        }

        /* INDIVIDUAL CONVERSION METHODS (INVOKED FROM METHODS ABOVE) */


        // CONVERTING TO UNSIGNED


        // CONVERTING TO SIGNED


        // CONVERTING TO ONE'S COMPLEMENT

        private string fromUnsignedToOnesComplement(string input)
        {
            char[] valueBreakdown = input.ToCharArray();

            for (int i = 0; i < valueBreakdown.Length; i++)
            {
                if (valueBreakdown[i].Equals('0'))
                {
                    valueBreakdown[i] = '1';
                }
                else
                {
                    valueBreakdown[i] = '0';
                }
            }

            return new String(valueBreakdown);
        }

        private string fromSignedToOnesComplement(string input)
        {
            return "";
        }

        private string fromTwosComplementToOnesComplement(string input)
        {
            return "";
        }

        private string fromDecimalToOnesComplement(string input)
        {
            return "";
        }

        // CONVERTING TO TWOS COMPLEMENT



        // CONVERTING TO DECIMAL



    }
}
