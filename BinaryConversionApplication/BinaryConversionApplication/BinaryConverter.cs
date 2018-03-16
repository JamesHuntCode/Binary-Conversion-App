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

                    if (input.ToCharArray()[0].Equals('0')) 
                    {
                        convertedValue = this.fromUnsignedToOnesComplement(input);
                    }
                    else 
                    {
                        convertedValue = this.fromSignedToOnesComplement(input);
                    }

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

                    convertedValue = this.fromUnsignedToDecimal(input);

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
            char[] valueBreakdown = input.ToCharArray();

            if (valueBreakdown.Length == 4) // 4 bit value
            {

            }
            else // 8 bit value
            {

            }

            return new String(valueBreakdown);
        }

        private string fromTwosComplementToOnesComplement(string input)
        {
            return "";
        }

        private string fromDecimalToOnesComplement(string input)
        {
            return "";
        }

        // CONVERTING TO TWO'S COMPLEMENT



        // CONVERTING TO DECIMAL

        private string fromUnsignedToDecimal(string input)
        {
            Dictionary<int, char> binaryValues = new Dictionary<int, char>();

            char[] inputValue = input.ToCharArray();

            string convertedValue = "";

            if (input.Length == 4) // 4 bit value
            {
                binaryValues.Add(8, inputValue[0]);
                binaryValues.Add(4, inputValue[1]);
                binaryValues.Add(2, inputValue[2]);
                binaryValues.Add(1, inputValue[3]);

                int sum = 0;

                foreach (KeyValuePair<int, char> binaryPosition in binaryValues)
                {
                    if (binaryPosition.Value.Equals('1'))
                    {
                        sum += binaryPosition.Key;
                    }
                }

                convertedValue = Convert.ToString(sum);

                binaryValues.Clear();
            }
            else // 8 bit value
            {
                binaryValues.Add(128, inputValue[0]);
                binaryValues.Add(64, inputValue[1]);
                binaryValues.Add(32, inputValue[2]);
                binaryValues.Add(16, inputValue[3]);
                binaryValues.Add(8, inputValue[4]);
                binaryValues.Add(4, inputValue[5]);
                binaryValues.Add(2, inputValue[6]);
                binaryValues.Add(1, inputValue[7]);
            }

            return convertedValue;
        }

        private string fromSignedToDecimal(string input)
        {
            return "";
        }

        private string fromOnesComplementToDecimal(string input)
        {
            return "";
        }

        private string fromTwosComplementToDecimal(string input)
        {
            return "";
        }
    }
}
