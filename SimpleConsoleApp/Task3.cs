using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleConsoleApp
{
    class Task31
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Введите размер очереди");
            int size = int.Parse(Console.ReadLine()) + 1;
            Console.WriteLine("Время ожидания");
            int time = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 1; i < size; i++)
            {
                array[i] = time * i;
                Console.WriteLine("Время пребывания в очереди клиента {0} время {1}", i, array[i]);
            }
        }
    }

    class Task32
    {
        static void Main1(string[] args)
        {

            int[,] inputs = { { 1, 2, 3 }, { 3, 2, 6 }, { 5, 3, 6 }, { 9, 7, 11 }, { 2, 12, 1 } };

            List<int> results = new List<int>();

            for (int i = 0; i < 5; i++)
            {

                int max = 0;
                for (int j = 0; j < 3; j++)
                {
                    max = inputs[i, j] > max ? inputs[i, j] : max;
                }

                results.Add(max);

            }
            int maxRes = 0;
            int id = 0;

            for (int z = 0; z < results.Count; z++)
            {
                if (results[z] > maxRes) { maxRes = results[z]; id = z; }

                Console.WriteLine("№ спортсмена:" + z + "Максимальный балл:" + results[z]);
            }

            Console.WriteLine("Победитель спортсмена №" + id + "С результатом " + maxRes);
        }
    }
}

