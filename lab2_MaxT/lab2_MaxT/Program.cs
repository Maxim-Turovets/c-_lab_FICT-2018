using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_MaxT
{
    class Program
    {
        static void Main(string[] args)
        {
            //  количество елементов , шаг
            Progression Lin_object1= new Linear(17,3);
         //   Lin_object1.Element(10);

            Progression Exp_object1 = new Exponential(10, 3);
           // Exp_object1.Element(9);

            Progression Lin_object2 = new Linear(10, 3);
            //Lin_object2.Element(3);

            Progression Exp_object2 = new Exponential(15, 2);
            // Exp_object2.Element(12);

            Progression Lin_object3 = new Linear(20, 5);
            // Lin_object3.Element(17);

            Linear Lin_object4 = new Linear(10, 2);
            Linear Lin_object5 = new Linear(20, 2);

            Series Series_object1 = new Series();
            Series_object1.list.Add(Lin_object1);
            Series_object1.list.Add(Exp_object1);
            Series_object1.list.Add(Lin_object2);
            Series_object1.list.Add(Exp_object2);
            Series_object1.list.Add(Lin_object3);

            Series Series_object2 = new Series();

            // Вывод коллекции со всей информацией и общей сумой прогрессий
               Series_object1.print();
            Console.WriteLine("=========================================================================");
            // Переопределение метода Equals
            Lin_object4.Equals(Lin_object5);

              // Переопределение операторов == и !=
              if (Lin_object4 == Lin_object5)
                  Console.WriteLine("Lin_object4 == Lin_object5");
              else
                  Console.WriteLine("Lin_object4 != Lin_object5");

            // Переопределение метода DeepCopy
            Series_object1.DeepCopy(Series_object2);
             Series_object2.print();
            Console.WriteLine("=========================================================================");


            // Переопределение метода ToString()
            Console.WriteLine(Series_object1.ToString());

            //  Console.WriteLine(Lin_object5.GetHashCode());

            Console.ReadKey();
        }
    }
}
