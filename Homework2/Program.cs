using System;

/// <summary>
/// Сахаров Олег
/// Домашняя работа номер 2
/// </summary>


namespace Homework2
{
    class Program
    {
        static ConsoleKey Menu()
        {

            Console.WriteLine("1 - task 1");
            Console.WriteLine("2 - task 2");
            Console.WriteLine("3 - task 3");
            Console.WriteLine("4 - task 4");
            Console.WriteLine("5 - task 5");
            Console.WriteLine("6 - task 6");
            Console.WriteLine("Esc - quit");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();
            return keyInfo.Key;
        }

        static void Main(string[] args)
        {
            ConsoleKey key;
            do
            {
                Console.Clear();
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
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        Homework2.Task3();
                        break;
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.D4:
                        Homework2.Task4();
                        break;
                    case ConsoleKey.NumPad5:
                    case ConsoleKey.D5:
                        Homework2.Task5();
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Bye-bye");
                        break;
                    default:
                        Console.WriteLine("Wrong!");
                        break;
                }
                Console.ReadLine();
            }
            while (key != ConsoleKey.Escape);
        }
    }
}
