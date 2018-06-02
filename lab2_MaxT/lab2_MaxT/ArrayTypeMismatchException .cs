using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_MaxT
{
   
    internal class ArrayTypeMismatchException : My_Exeption
    {
        public ArrayTypeMismatchException(string message)
            : base(message)
        {
        }
    }
}
