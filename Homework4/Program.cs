using System;

/// <summary>
/// 1. Дан целочисленный массив из 20 элементов. Элементы массива могут 
/// принимать целые значения от –10 000 до 10 000 включительно. Написать 
/// программу, позволяющую найти и вывести количество пар элементов массива, 
/// в которых хотя бы одно число делится на 3. В данной задаче под парой 
/// подразумевается два подряд идущих элемента массива. Например, для массива 
/// из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
/// </summary>
/// 

namespace Homework4
{
    partial class Program
    {
        static string Menu()
        {

            Console.WriteLine("1 - Pairs of array");
            Console.WriteLine("2 - Array class");
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
                    case "2":
                        Task2();
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
