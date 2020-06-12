using System;

namespace Homework4
{
    partial class Program
    {
        static string Menu()
        {

            Console.WriteLine("1 - Pairs of array");
            Console.WriteLine("1 - Pairs of array");
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
                        Task1();
                        break;
                    case "q":
                        Console.WriteLine("Bye-bye");
                        break;
                    default:
                        Console.WriteLine("Wrong!");
                        break;
                }
            }
            while (number != "q");
        }
    }
}
