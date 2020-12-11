using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleConsoleApp
{
    class Task21
    {
        static void Main1(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += (2 * i + 1);
            }
            Console.WriteLine(sum);
        }

    }
    class Task22
    {
        static void Main1(string[] args)
        {
            int t = 0;
            for (int b = 0; b < 10; b++)
            {
                for (int k = 0; k < 20; k++)
                {
                    t = 100 - (b + k);
                    if (20 * b + 10 * k + t == 200)
                    {
                        Console.WriteLine("Быков {0} коров {1} телят {2}", b, k, t);
                        return;
                    }
                }
            }
        }
    }

    class Task23
    {
        static void Main1(string[] args)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            Console.WriteLine("Введите количество участинц");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите айди и баллы через пробел");
                String[] array = Console.ReadLine().Split(" ");

                if (!pairs.ContainsKey(int.Parse(array[0])))
                {
                    pairs.Add(int.Parse(array[0]), int.Parse(array[1]));
                }
                else
                {
                    pairs[int.Parse(array[0])] += int.Parse(array[1]);
                }
            }

            int id = 0;
            int bal = 0;
            foreach (var a in pairs)
            {
                if (a.Value > bal)
                {
                    bal = a.Value;
                    id = a.Key;
                }
            }

            Console.WriteLine("Участница {0} имеет максимальный бал {1}",id,bal);

        }
    }

}
