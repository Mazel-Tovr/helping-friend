using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleConsoleApp
{
    class Task41
    {
        static void Main1(string[] args)
        {
            String input = Console.ReadLine();
            String encrypted = "";
            String decrypted = "";

            foreach (char c in input)
            {
                encrypted += ((char)((int)c - 2)).ToString();
            }
            Console.WriteLine("Зашифрованный текс " + encrypted);
            foreach (char c in encrypted)
            {
                decrypted += ((char)((int)c + 2)).ToString();
            }
            Console.WriteLine("Расшифрованный текст " + decrypted);
        }
    }
    class Task42
    {
        static void Main1(string[] args)
        {
            String input = Console.ReadLine();

            input = input.Replace(@"меньше","<");
            input = input.Replace(@"больше", ">");
            input = input.Replace(@"равно", "=");

            Console.WriteLine("Ответ: "+ input);
        }
    }
}
