using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_MaxT
{
   
    internal class InvalidCastException : My_Exeption
    {
        public InvalidCastException(string message)
            : base(message)
        {
        }
    }
}
