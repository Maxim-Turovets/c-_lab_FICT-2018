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
            Progression Lin_object1= new Linear(10,3);
           // Lin_object1.Element(5);

            Progression Exp_object1 = new Exponential(10, 3);
           // Exp_object1.Element(9);

            Progression Lin_object2 = new Linear(5, 3);
            //Lin_object2.Element(3);

            Progression Exp_object2 = new Exponential(15, 2);
            // Exp_object2.Element(12);

            Progression Lin_object3 = new Linear(20, 5);
            // Lin_object3.Element(17);

            Series Series_object1 = new Series();
            Series_object1.list.Add(Lin_object1);
            Series_object1.list.Add(Exp_object1);
            Series_object1.list.Add(Lin_object2);
            Series_object1.list.Add(Exp_object2);
            Series_object1.list.Add(Lin_object3);

            // Вывод коллекции со всей информацией и общей сумой прогрессий
            Series_object1.print();

            Console.ReadKey();
        }
    }
}
