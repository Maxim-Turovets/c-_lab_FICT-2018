using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_MaxT
{
    class Series 
    {
        public List<Progression> list = new List<Progression>();
        
        public Series(Progression o)
        {
            this.list.Add(o);
        }
        public Series()
        {
            
        }

        public void print()
        {
            double sum_total= 0;
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].name == "Linear")
                    Console.WriteLine("         Linear progression");
                else
                    Console.WriteLine("         Exponential progression");
                Console.WriteLine(this.list[i].Sum());
            }

            for (int i = 0; i < this.list.Count; i++)
            {
                sum_total += this.list[i].Suma;
            }

            Console.WriteLine("\nSum Total = "+sum_total);
        }

        public List<Progression> DeepCopy( Series obj)
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                obj.list.Add ( this.list[i]);
            }
            return obj.list;
        }

        public override string ToString()
        {
            Console.WriteLine("Series info:");
            string str="";
            for (int i = 0; i < this.list.Count; i++)
            {
                str += "Object("+(i+1)+")-"+ this.list[i].name+"; ";
            }
            return str;
        }
    }
}
