using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionApplication
{
    public class RawBinaryInput
    {
        public string Value { get; set; }
        public bool IsUnsigned { get; set; }
        public bool IsSigned { get; set; }
        public bool IsOnesComplement { get; set; }
        public bool IsTwosComplement { get; set; }

        public RawBinaryInput()
        {

        }
    }
}
