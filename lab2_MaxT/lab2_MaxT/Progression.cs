using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  lab2_MaxT
{
     public abstract class Progression
    {
        public string name;
        public double Suma;
        public virtual double Element(int index)
        {
            return 0;
        }
        public virtual double Sum ()
        {
            return 0;
        }
        public virtual double Get_Suma()
        {
            return 0;
        }
      
    }
}
