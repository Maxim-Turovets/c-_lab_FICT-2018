using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_MaxT
{

    internal class OutOfMemoryException : My_Exeption
    {
        public OutOfMemoryException(string message)
            : base(message)
        {
        }
    }
}
