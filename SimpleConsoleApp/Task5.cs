using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleConsoleApp
{
    class Task51
    {
        
        static void Main1(string[] args)
        {
            Console.WriteLine("Введит размер");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Символ вывода");
            String simble = Console.ReadLine();
            Console.WriteLine("Х");
            int startPos = int.Parse(Console.ReadLine());
            Console.WriteLine("Y");
            int y = int.Parse(Console.ReadLine());
            for (int i = 0; i < y; i++)
            {
                Console.WriteLine();
            }
            printBoard(a,simble,startPos);
            printFoot(a, simble, startPos);
            printFoot(a, simble, a + startPos -1);
            printBoard(a, simble, a + startPos -1);

        }
        private static void printBoard(int size,String simble, int startPos)
        {
            Console.Write(new String(' ', startPos) );
            for (int i = 0; i < size; i++)
            {
                Console.Write(simble);
            }
            Console.WriteLine();
        }
        private static void printFoot(int size, String simble,int startPos)
        {
            for (int i = 0; i < size-1; i++)
            {
                Console.WriteLine(new String(' ', startPos) + simble +new String(' ',size-2) + simble);
            }
        }
    }

    class Task52
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Количество месяцев");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество лет");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Начальное кол-во пар");
            int start = int.Parse(Console.ReadLine());
            int fitst = 0, second = 0, third = start;

            int all = a + (y * 12);



            for (int i = 0; i < all-1; i++)
            {
                int temp1 = fitst;
                int temp2 = second;
                fitst += third;
                second += temp1;
                third += temp2;
            }

            Console.WriteLine("Ответ всего пар кроликов "+(third+second+fitst));

        }


    }

}
