using System;

//Сахаров Олег
//1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры;
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;

//2. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
//Написать программу, демонстрирующую все разработанные элементы класса. Достаточно решить 2 задачи. Все программы сделать в одном решении.
//** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
//ArgumentException("Знаменатель не может быть равен 0");
//Добавить упрощение дробей.

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

