using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                    if (isPositiveBinary(input, true))
                    {
                        convertedValue = input;
                    }
                    else
                    {
                        return returnNA();
                    }

                    break;
                case "ones-complement":

                    if (isPositiveBinary(input, true))
                    {
                        convertedValue = this.invertBitValues(input);
                    }
                    else
                    {
                        return returnNA();
                    }

                    break;
                case "twos-complement":

                    if (isPositiveBinary(input, true))
                    {
                        convertedValue = this.fromTwosComplementToUnsigned(input);
                    }
                    else
                    {
                        return returnNA();
                    }

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
            string convertedValue = "";

            switch (repType)
            {
                case "unsigned":

                    convertedValue = input;

                    break;
                case "signed":

                    convertedValue = input;

                    break;
                case "ones-complement":

                    convertedValue = this.fromOnesComplementToSigned(input);

                    break;
                case "twos-complement":

                    convertedValue = this.fromTwosComplementToSigned(input);

                    break;
                case "decimal":

                    if (isPositiveInteger(input))
                    {
                        convertedValue = this.fromDecimalToUnsigned(input);
                    }
                    else
                    {
                        convertedValue = this.fromDecimalToSigned(input);
                    }

                    break;
            }

            return convertedValue;
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

                    convertedValue = this.fromTwosComplementToOnesComplement(input);

                    break;
                case "decimal":

                    convertedValue = this.fromDecimalToOnesComplement(input);

                    break;
            }

            return convertedValue;
        }

        // Method to convert user input into a two's complement binary number
        public string ConvertToTwosComplement(string input, string repType)
        {
            string convertedValue = "";

            switch (repType)
            {
                case "unsigned":

                    convertedValue = this.fromUnsignedToTwosComplement(input);

                    break;
                case "signed":

                    convertedValue = this.fromSignedToTwosComplement(input);

                    break;
                case "ones-complement":

                    convertedValue = this.fromOnesComplementToTwosComplement(input);

                    break;
                case "twos-complement":

                    convertedValue = input;

                    break;
                case "decimal":

                    convertedValue = this.fromDecimalToTwosComplement(input);

                    break;
            }

            return convertedValue;
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

        // Method to convert user input into a floating point number
        public string ConvertToFloat(string input, string repType)
        {
            string convertedValue = "";

            switch (repType)
            {
                case "unsigned":

                    convertedValue = this.fromUnsignedToFloat(input);

                    break;
                case "signed":

                    convertedValue = this.fromSignedToFloat(input);

                    break;
                case "ones-complement":

                    convertedValue = this.fromOnesComplementToFloat(input);

                    break;
                case "twos-complement":

                    convertedValue = this.fromTwosComplementToFloat(input);

                    break;
            }

            return convertedValue;
        }

        /*###############################################################################
          #                                                                             #
          #                        CONVERTING TO UNSIGNED                               #
          #                                                                             #
          ###############################################################################*/

        // Method to covert from twos's complement binary to unsigned
        private string fromTwosComplementToUnsigned(string input)
        {
            string decimalValue = this.fromTwosComplementToDecimal(input);
            string unsignedValue = this.fromDecimalToUnsigned(decimalValue);
            return unsignedValue;
        }

        // Method to convert from a decimal value to unsigned binary
        private string fromDecimalToUnsigned(string input) 
        {
            // place to store remainders (which indicate binary value)
            List<char> binaryValues = new List<char>();

            int currentValue = Convert.ToInt32(input);

            while (currentValue != 0)
            {
                int remainder = currentValue % 2;

                if (remainder > 0)
                {
                    binaryValues.Add('1');
                }
                else
                {
                    binaryValues.Add('0');
                }

                currentValue /= 2;
            }

            // convert to 8 bit value
            if (binaryValues.Count != 8)
            {
                while (binaryValues.Count < 8)
                {
                    binaryValues.Add('0');
                }
            }

            // Format output and return value
            binaryValues.Reverse();
            string formattedOutput = string.Join("", binaryValues.ToArray());
            return formattedOutput;
        }

        /*##############################################################################
         #                                                                             #
         #                            CONVERTING TO SIGNED                             #
         #                                                                             #
         ###############################################################################*/

        // Method to convert one's complement to signed binary
        private string fromOnesComplementToSigned(string input)
        {
            return this.invertBitValues(input);
        }

        // Method to convert twos's complement to signed binary
        private string fromTwosComplementToSigned(string input)
        {
            string onescomp = this.fromTwosComplementToOnesComplement(input);
            string signed = this.invertBitValues(onescomp);
            return signed;
        }

        // Method to convert decimal to signed binary
        private string fromDecimalToSigned(string input)
        {
            string positiveInput = "";

            if (input.Contains('-'))
            { 
                positiveInput = input.Remove(0, 1);
            }
            else
            {
                positiveInput = input;
            }

            string unsigned = this.fromDecimalToUnsigned(positiveInput);
            char[] bits = unsigned.ToCharArray();

            if (input.Contains('-'))
            {
                bits[0] = '1';
            }
            else
            {
                bits[0] = '0';
            }

            return new String(bits);
        }

        /*##############################################################################
         #                                                                             #
         #                      CONVERTING TO ONE'S COMPLEMENT                         #
         #                                                                             #
         ###############################################################################*/

        // Method to convert from a signed binary value to one's complement
        private string fromSignedToOnesComplement(string input)
        {
            return this.invertBitValues(input);
        }

        // Method to convert from a decimal value to one's complement binary
        private string fromDecimalToOnesComplement(string input)
        {
            string signedValue = this.fromDecimalToSigned(input);
            return this.invertBitValues(signedValue);
        }

        // Method to convert from a two's complement binary value to one's complement
        private string fromTwosComplementToOnesComplement(string input)
        {
            string unsigned = this.fromTwosComplementToUnsigned(input);
            string onesComplement = this.invertBitValues(unsigned);
            return onesComplement;
        }

        /*##############################################################################
         #                                                                             #
         #                     CONVERTING TO TWO'S COMPLEMENT                          #
         #                                                                             #
         ###############################################################################*/

        // Method to convert from unsigned to two's complement
        private string fromUnsignedToTwosComplement(string input)
        {
            string onescomp = this.invertBitValues(input);
            string twoscomp = this.fromOnesComplementToTwosComplement(onescomp);
            return twoscomp;
        }

        // Method to convert from signed binary to two's complement
        private string fromSignedToTwosComplement(string input)
        {
            int dec = Convert.ToInt32(this.fromSignedToDecimal(input));
            string decPlus1 = Convert.ToString(dec + 1);
            string twoscomp = this.fromDecimalToOnesComplement(decPlus1);
            return twoscomp;
        }

        // Method to convert from one's complement to two's complement
        private string fromOnesComplementToTwosComplement(string input)
        {
            int dec = Convert.ToInt32(this.fromOnesComplementToDecimal(input));
            string decPlus1 = Convert.ToString(dec + 1);
            string twoscomp = this.fromDecimalToOnesComplement(decPlus1);
            return twoscomp;
        }

        // Method to convert from decimal to two's complement
        private string fromDecimalToTwosComplement(string input)
        {
            string decPlus1 = Convert.ToString(Convert.ToInt32(input) + 1);
            string twoscomp = this.fromDecimalToOnesComplement(decPlus1);
            return twoscomp;
        }

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

            bool isPositive = (inputValue[0].Equals('0'));

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
            int twosComp = getOnesComp - 1;

            return twosComp.ToString();
        }

        /*##############################################################################
         #                                                                             #
         #                          CONVERTING TO FLOAT                                #
         #                                                                             #
         ###############################################################################*/

        // Method to convert from unsigned binary to floating point
        private string fromUnsignedToFloat(string input)
        {
            return "Not yet available.";
        }

        // Method to convert from signed binary to floating point
        private string fromSignedToFloat(string input)
        {
            return "Not yet available.";
        }

        // Method to convert from ones complement binary to floating point
        private string fromOnesComplementToFloat(string input)
        {
            return "Not yet available.";
        }

        // Method to convert from twos complement binary to floating point
        private string fromTwosComplementToFloat(string input)
        {
            return "Not yet available.";
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

        // Method to determine if binary number is positive
        private bool isPositiveBinary(string binaryValue, bool inverted)
        {
            char[] bits = binaryValue.ToCharArray();
            bool isPositive = true;

            if (inverted)
            {
                isPositive = (bits[0].Equals('1'));
            }
            else
            {
                isPositive = (bits[0].Equals('0'));
            }

            return isPositive;
        }

        // Method to determine if integer input is positive
        private bool isPositiveInteger(string input)
        {
            return (Convert.ToInt32(input) > 0);
        }

        // If illegal conversion occurs (negative signed to unsigned etc) return "N/A"
        private string returnNA()
        {
            return "N/A";
        }
    }
}
