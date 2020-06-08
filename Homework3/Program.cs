using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static string Menu()
        {

            Console.WriteLine("1 - Complex number 1");
            Console.WriteLine("2 - Fractional numbers 2");
            Console.WriteLine("q - Quit");
            string numInfo = Console.ReadLine();
            Console.WriteLine();
            return numInfo.ToLower();
        }

        static void Main(string[] args)
        {
            string number;
            do
            {
                Console.Clear();
                number = Menu();
                switch (number)
                {
                    case "1":
                        Homework3.Task1();
                        break;
                    case "2":
                        Homework3.Task2();
                        break;
                    case "q":
                        Console.WriteLine("Bye-bye");
                        break;
                    default:
                        Console.WriteLine("Wrong!");
                        break;
                }
                Console.ReadLine();
            }
            while (number != "q");
        }
    }
}

