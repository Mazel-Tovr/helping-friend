using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleConsoleApp
{
    class Task11
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Введите данное число");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число");
            String input1 = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < input1.Length; i++)
            {
                sum = int.Parse(input1[i].ToString());
            }
            Console.WriteLine(sum == input ? "Сумма числа равна данному числу" : sum > input ? "Сумма числа больше данной суммы" : "Сумма числа меньшей данной суммы");
        }
    }

    class Task12
    {
        static void Main1(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int mod = input % 10;

            List<int> exceptions = new List<int> { 11, 12, 13, 14 };

            if (exceptions.Contains(input))
            {
                Console.WriteLine(input + " рублей");
                return;
            }

            if (mod == 1)
            {
                Console.WriteLine(input + " рубль");
            }
            else
            {
                if (mod > 1 && mod < 5)
                {
                    Console.WriteLine(input + " рубля");
                }
                else
                {
                    Console.WriteLine(input + " рублей");
                }
            }
        }
    }

    class Task13
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Введите день");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год");
            int year = int.Parse(Console.ReadLine());

            DateTime dateTime = new DateTime(year, month, day);
            Console.WriteLine("Следующий день "+ dateTime.AddDays(1).ToLongDateString());  

        }
    }

}

//Console.WriteLine(new DateTime(2015,11,1).ToLongDateString());
