using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
//1. Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double, double).
// Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).

//2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
//а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
//б) Используйте массив(или список) делегатов, в котором хранятся различные функции.
//в) * Переделайте функцию Load, чтобы она возвращала массив считанных значений.Пусть она
//возвращает минимум через параметр.

//3. Переделать программу «Пример использования коллекций» для решения следующих задач:
//а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
//б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
//в) отсортировать список по возрасту студента;
//г) * отсортировать список по курсу и возрасту студента;
//д) разработать единый метод подсчета количества студентов по различным параметрам
// выбора с помощью делегата и методов предикатов.
    partial class Program
    {
        static string Menu()
        {
            Console.WriteLine("1 - Функции");
            Console.WriteLine("2 - Минимум функции");
            //Console.WriteLine("3 - Account");
            //Console.WriteLine("4 - Matrix");
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
                    case "2":
                        Task2();
                        break;
                    //case "3":
                    //    Task3();
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
