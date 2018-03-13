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
        public bool IsUnsigned { get; set; } = false;
        public bool IsSigned { get; set; } = false;
        public bool IsOnesComplement { get; set; } = false;
        public bool IsTwosComplement { get; set; } = false;

        public RawBinaryInput()
        {

        }
    }
}
