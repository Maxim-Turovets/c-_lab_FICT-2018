using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_MaxT
{
    class Exponential : Progression
    {
        private int n;
        private double d;
        private double[] mas;
    

        public Exponential(int n, double d)
        {
            n++;
            this.n = n;
            this.d = d;
            mas = new double[n];
            this.name = "Exponential";
        }


        public override double Element(int index)
        {
            if (index > this.n - 1 || index < 0)
            {
                throw new ArrayTypeMismatchException("\nError not index!!!\n");
                return 0;
            }
            else
            {
                double element;
                if (index == 1)
                {
                    element = this.d;
                    Console.Write("Element " + index + " = " + element);
                    return element;
                }
                else
                {
                    index--;
                    element = this.mas[index - 1] * this.d;
                    Console.Write("Element " + (index+1) + " = " + element);
                    return element;
                }
            }

        }

        public override double Sum()
        {
            double sum = 0;
            for (int i = 0; i < this.n - 1; i++)
            {
                this.mas[0] = this.d;
                this.mas[i + 1] = this.mas[i] * this.d;

                Console.Write(this.mas[i] + " ");
            }
            for (int i = 0; i < this.n - 1; i++)
            {
                sum = sum + this.mas[i];
            }
            Console.WriteLine("\nSum :" + sum);
            this.Suma = sum; 
            return sum;
        }

        public override double Get_Suma()
        {
            return this.Suma;
        }

        public bool Equals(Exponential obj)
        {
            this.n = obj.n;
            this.d = obj.d;
            this.name = obj.name;
            return true;
        }

        public static bool operator !=(Exponential obj, Exponential obj2)
        {
            return obj.Equals(obj2);
        }

        public static bool operator ==(Exponential obj, Exponential obj2)
        {
            return obj.Equals(obj2);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        
    }
}
