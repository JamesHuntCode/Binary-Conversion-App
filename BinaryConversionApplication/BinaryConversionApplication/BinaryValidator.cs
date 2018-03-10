using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                return true;
            } 
            else if (input.Length == 4)
            {
                // 4 bit binary input
                return true;
            }
            else
            {
                // invalid input
                return false;
            }
        }
    }
}
