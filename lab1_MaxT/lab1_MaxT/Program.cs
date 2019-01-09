using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Задача решается следующим образом. Выбирается произвольный человек и помещается в первую группу. 
 * Затем находятся люди, ему знакомые. Понятно, что они не могут находиться в первой группе, 
 * поэтому их необходимо поместить во вторую. Затем находятся люди, знакомые людям из второй группы. 
 * Понятно, что они не могут находиться во второй группе, поэтому их необходимо поместить в первую. 
 * Повторяя так поочередно для каждой из групп, мы придем к одной из ситуаций:

1. Какой-то человек сначала был помещен в одну группу, а потом должен быть помещен в другую.
    Понятно, что в этом случае задача не имеет решения.

2. Каждый человек помещен в одну из групп. В этом случае задача решена.

3. Не каждый человек помещен в одну из групп. Это означает, что оставшиеся не помещенные в группы люди не знакомы людям
в группах (иначе они были бы куда-нибудь помещены). Следовательно, одного из них безразлично куда помещать, например 
в первую группу. Затем описанный выше процесс продолжается, пока не придем к ситуации 1. или 2.
*/
namespace lab1_MaxT
{
    class Program
    {
        static void Main(string[] args)
        {
            // вводимые данные 
                int n = 4;
                int[,] mas = new int[n, n];
                information(mas);
            // построение матрицы
                building(mas, n);
            // печать матрицы
                printing(mas, n);
            // создание спсков груп
                List<int> list1 = new List<int>();
                List<int> list2 = new List<int>();
            // распределение по спискам
                addition(list1, list2, mas, n);
            
                bool output = conclusion(list2, mas);
            // вывод списков (если это возможно)
                if (conclusion(list2, mas) == true)
                    conclusion_2(list1, list2);
            Console.ReadKey();
        }

        // метод для ВВОДА ДАННЫХ
        static void information(int[,] mas)
        {
            mas[0, 3] = 1;
            mas[0, 2] = 1;     
        }
        static void building (int[,] mas, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        mas[i, j] = 1;

                    if (mas[i, j] == 1)
                        mas[j, i] = 1;
                    else
                        mas[i, j] = 0;

                    if (mas[j, i] == 1)
                        mas[i, j] = 1;
                    else
                        mas[j, i] = 0;
                }
            }
        }

        static void printing(int[,] mas, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i > 9)
                    Console.Write("Person " + (i) + " - ");
                else
                    Console.Write("Person " + (i) + " -  ");
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mas[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void addition (List<int> list1,List <int> list2, int[,] mas, int n)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {

                for (int z = 0; z < list2.Count; z++)
                    if (i == list2[z])
                        count = 1;

                if (count == 1)
                {
                    count = 0;
                    continue;
                }

                list1.Add(i);

                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        if (mas[i, j] == 1)
                        {
                            list2.Add(j);
                        }
                    }
                }

            }
        }

        static bool conclusion (List<int>list2, int[,] mas)
        {
            bool yes_no = true;
            for (int i = 1; i < list2.Count; i++)
            {
                if (list2[i - 1] != list2[i])
                {
                    if (mas[list2[i - 1], list2[i]] == 1)
                    {
                        yes_no= false;
                        Console.WriteLine("\nThe distribution of people is not possible!!!");
                    }
                }
            }
            return yes_no;
        }
        static void conclusion_2(List<int>list1, List<int> list2)
        {
            Console.Write("\nDistribution of people :\n");
            for (int i = 0; i < list1.Count; i++)
                Console.Write(list1[i] + " ");

            Console.Write("\n");

            for (int i = 0; i < list2.Count; i++)
                Console.Write(list2[i] + " ");
        }
    }
}
