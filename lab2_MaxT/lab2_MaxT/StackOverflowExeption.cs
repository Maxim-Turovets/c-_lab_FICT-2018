using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_MaxT
{
   
    internal class StackOverflowExeption : My_Exeption
    {
        public StackOverflowExeption(string message)
            : base(message)
        {
        }
    }
}
