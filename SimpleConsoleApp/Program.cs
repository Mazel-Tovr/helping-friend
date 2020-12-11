using System;
using static System.Console;

namespace SimpleConsoleApp
{
    class Program
    {

        private const String exitInput = "!exit";
        private const String info = "Write 1 to firs task : Get biger of two number \n" +
                              "Write 2 to second task work with triangle \n" +
                              "Write " + exitInput + "to exit";
        static void main(string[] args)
        {
         
            bool flag = true;
            while (flag)
            {
                WriteLine("Choose option!");
                WriteLine(info);
                String input = ReadLine();
                switch (input)
                {
                    case "1":
                        new BigestNumer().start();
                        break;
                    case "2":
                        new Triangle().start();
                        WriteLine();
                        break;
                    case exitInput:
                        Environment.Exit(0);
                        WriteLine();
                        break;
                    default:
                        WriteLine("Write 1,2 or" + exitInput);
                        break;

                }

            }
        }
    }

    class BigestNumer
    {
        public void start()
        {
            int firstNumber = getNumber("first");
            int secondNumber = getNumber("second");

            WriteLine(firstNumber == secondNumber ? "Nubers are equal" :
                firstNumber > secondNumber ?
                "First number is bigger then second" :
                "Second number is bigger then first");

        }

        private int getNumber(String number)
        {
            int result;
            while (true)
            {
                WriteLine("Write a " + number + " number");
                String input = ReadLine();
                if (input.Length == 2)
                {
                    if (!Int32.TryParse(input, out result))
                    {
                        WriteLine("Only numbers allowed");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    WriteLine("Number length should be 2 char");
                }
            }
            return result;
        }
    }

    class Triangle
    {
        public void start()
        {
            int firstNumber = getNumber("first");
            int secondNumber = getNumber("second");
            int thirdNumber = getNumber("third");

            if(!(firstNumber + secondNumber > thirdNumber || firstNumber + thirdNumber > secondNumber || secondNumber +thirdNumber > firstNumber))
            {
                WriteLine("This triangle doesn't exists");
                return;
            }
            if(firstNumber == secondNumber && firstNumber == thirdNumber && secondNumber == thirdNumber)
            {
                WriteLine("This triangle is equilateral");
                return;
            }
            if ((firstNumber == secondNumber && firstNumber != thirdNumber) || (firstNumber == thirdNumber && firstNumber != secondNumber))
            {
                WriteLine("This triangle is isosceles");
                return;
            }

            WriteLine("This triangle is versatile");

        }
        private int getNumber(String number)
        {
            int result;
            while (true)
            {
                WriteLine("Write a " + number + " number");
                String input = ReadLine();

                if (!Int32.TryParse(input, out result))
                {
                    WriteLine("Only numbers allowed");
                }
                else
                {
                    break;
                }

            }
            return result;
        }


    }

}

