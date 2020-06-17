using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework5
{
    public partial class Program
    {
        static string Menu()
        {
            Console.WriteLine("1 - Авторизация");
            Console.WriteLine("2 - Array class");
            Console.WriteLine("3 - Account");
            Console.WriteLine("4 - Matrix");
            Console.WriteLine("q - Quit");
            string numInfo = Console.ReadLine();
            Console.WriteLine();
            return numInfo.ToLower();
        }

        static void Main()
        {
            string number;
            do
            {
                Console.Clear();
                number = Menu();
                switch (number)
                {
                    case "1":
                        Task1();
                        break;
                    //case "2":
                    //    Task2();
                    //    break;
                    //case "3":
                    //    Task3();
                    //    break;
                    //case "4":
                    //    Task4();
                    //    break;
                    case "q":
                        Console.WriteLine("Bye-bye");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Wrong!");
                        Console.ReadLine();
                        break;
                }
            }
            while (number != "q");
        }
    }
}
