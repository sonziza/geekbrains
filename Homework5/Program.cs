using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Олег Сахаров
//1. Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//б) с использованием регулярных выражений.

//2. Разработать класс Message, содержащий следующие статические методы для обработки
//текста:
//а) Вывести только те слова сообщения, которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
//Продемонстрируйте работу программы на текстовом файле с вашей программой.

    //TODO: Узнать про принцип работы String.OrderBy 
//3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
//а) с использованием методов C#;
//б) * разработав собственный алгоритм.
// Например:
//badc являются перестановкой abcd.


namespace Homework5
{
    partial class Program
    {
        static string Menu()
        {
            Console.WriteLine("1 - Авторизация");
            Console.WriteLine("2 - Класс Message");
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
                    case "3":
                        Task3();
                        break;
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
