using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_MaxT
{
    
    internal class OverflowException : My_Exeption
    {
        public OverflowException(string message)
            : base(message)
        {
        }
    }
}
