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
            string convertedValue = "";

            switch (repType)
            {
                case "unsigned":

                    convertedValue = input;

                    break;
                case "signed":

                    

                    break;
                case "ones-complement":

                    

                    break;
                case "twos-complement":



                    break;
                case "decimal":

                    convertedValue = this.fromDecimalToUnsigned(input);

                    break;
            }

            return convertedValue;
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

                    convertedValue = this.invertBitValues(input);

                    break;
                case "signed":

                    convertedValue = this.fromSignedToOnesComplement(input);

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

                    convertedValue = this.fromSignedToDecimal(input);

                    break;
                case "ones-complement":

                    convertedValue = this.fromOnesComplementToDecimal(input);

                    break;
                case "twos-complement":

                    convertedValue = this.fromTwosComplementToDecimal(input);

                    break;
            }

            return convertedValue;
        }

        /*##############################################################################
          #                                                                             #
          #                        CONVERTING TO UNSIGNED                               #
          #                                                                             #
          ###############################################################################*/

        
        private string fromSignedToUnisigned(string input)
        {
            return "";
        }

        private string fromOnesComplementToUnsigned(string input)
        {
            return "";
        }

        private string fromTwosComplementToUnsigned(string input)
        {
            return "";
        }

        // Method to convert from a decimal value to unsigned binary
        private string fromDecimalToUnsigned(string input) 
        {
            // values needed for conversion algorithm
            double inputValue = Convert.ToInt32(input);
            const double baseVal = 2;

            // place to store remainders (which indicate binary value)
            List<char> binaryValues = new List<char>();

            while (/* condition for repeating division by 2 */)
            {
                // implement conversion algorithm here
            }

            // Format output and return value
            binaryValues.Reverse();

            string formattedOutput = string.Join("", binaryValues.ToArray());
            return formattedOutput;
        }

        // CONVERTING TO SIGNED


        /*##############################################################################
         #                                                                             #
         #                      CONVERTING TO ONE'S COMPLEMENT                         #
         #                                                                             #
         ###############################################################################*/

        // Method to convert from a signed binary value to one's complement
        private string fromSignedToOnesComplement(string input)
        {
            return "";
        }

        // Method to convert from a decimal value to one's complement binary
        private string fromDecimalToOnesComplement(string input)
        {
            return "";
        }

        // Method to convert from a two's complement binary value to one's complement
        private string fromTwosComplementToOnesComplement(string input)
        {
            return "";
        }

        /*##############################################################################
         #                                                                             #
         #                     CONVERTING TO TWO'S COMPLEMENT                          #
         #                                                                             #
         ###############################################################################*/



        /*##############################################################################
         #                                                                             #
         #                        CONVERTING TO DECIMAL                                #
         #                                                                             #
         ###############################################################################*/

        // Method to convert unsigned binary values to decimal
        private string fromUnsignedToDecimal(string input)
        {
            Dictionary<int, char> binaryValues = new Dictionary<int, char>();

            char[] inputValue = input.ToCharArray();

            string convertedValue = "";

            if (input.Length == 4)
            {
                int startingBinary = 8;

                for (int i = 0; i < 4; i++)
                {
                    binaryValues.Add(startingBinary, inputValue[i]);

                    startingBinary /= 2;
                }

                int sum = this.getBinarySum(binaryValues);

                convertedValue = Convert.ToString(sum);
            }
            else
            {
                int startingBinary = 128;

                for (int i = 0; i < 8; i++)
                {
                    binaryValues.Add(startingBinary, inputValue[i]);

                    startingBinary /= 2;
                }

                int sum = this.getBinarySum(binaryValues);

                convertedValue = Convert.ToString(sum);
            }

            // Clear previous values and return result
            binaryValues.Clear();
            return convertedValue;
        }

        // Method to convert signed binary values to decimal
        private string fromSignedToDecimal(string input)
        { 
            Dictionary<int, char> binaryValues = new Dictionary<int, char>();

            char[] inputValue = input.ToCharArray();

            bool isPositive = inputValue[0].Equals('0');

            string convertedValue = "";

            if (isPositive)
            {
                convertedValue = this.fromUnsignedToDecimal(input);
            }
            else
            {
                int startingBinary = 64;

                for (int i = 0; i < 7; i++)
                {
                    binaryValues.Add(startingBinary, inputValue[i + 1]);

                    startingBinary /= 2;
                }

                int sum = this.getBinarySum(binaryValues);

                convertedValue = "-" + Convert.ToString(sum);
            }

            // Clear previous values and return result
            binaryValues.Clear();
            return convertedValue;
        }

        // Method to convert one's complement binary values to decimal
        private string fromOnesComplementToDecimal(string input)
        {
            // 'un-invert' bits 
            string uninvertedBitValues = this.invertBitValues(input);

            // Convert from signed to decimal
            string convertedValue = this.fromSignedToDecimal(uninvertedBitValues);

            return convertedValue;
        }

        // Method to convert two's complement binary values to decimal
        private string fromTwosComplementToDecimal(string input)
        {
            // get one's complement value & add 1
            int getOnesComp = Convert.ToInt32(this.fromOnesComplementToDecimal(input));
            int twosComp = getOnesComp + 1;

            return twosComp.ToString();
        }

        /*##############################################################################
         #                                                                             #
         #                        ABSTRACT METHODS USED                                #
         #                                                                             #
         ###############################################################################*/

        // Method used to invert all bits in binary value
        private string invertBitValues(string input)
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

        // Method used to get sum of binary value
        private int getBinarySum(Dictionary<int, char> values)
        {
            int sum = 0;

            foreach (KeyValuePair<int, char> binaryPosition in values)
            {
                if (binaryPosition.Value.Equals('1'))
                {
                    sum += binaryPosition.Key;
                }
            }

            return sum;
        }
    }
}
