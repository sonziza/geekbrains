using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static ConsoleKey Menu()
        {

            Console.WriteLine("1 - task 1");
            Console.WriteLine("2 - task 2");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();
            return keyInfo.Key;
        }

        static void Main(string[] args)
        {
            ConsoleKey key;
            do
            {
                key = Menu();
                switch (key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        Homework2.Task1();
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        Homework2.Task2();
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Bye-bye");
                        break;
                    default:
                        Console.WriteLine("Wrong!");
                        break;
                }
            }
            while (key != ConsoleKey.Escape);
        }
    }
}
