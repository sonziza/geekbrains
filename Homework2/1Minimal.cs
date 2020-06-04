using System;
/// <summary>
/// Написать метод, возвращающий минимальное из трех чисел.
/// </summary>

namespace Homework2
{
    public partial class Homework2
    {
    /// <summary>
    /// Нахождение минимального из трех чисел
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns>минимальное значение</returns>
        static int GetMinimum(int a, int b, int c)
        {
            if (a <= b && a <= c)
            {
                return a;
            }
            else if (b <= a && b <= c)
            {
                return b;
            }
            else 
            { 
                return c;
            }    
        }
        public static void Task1()
        {
            Console.WriteLine("Enter first value:");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second value:");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third value:");
            int third = Convert.ToInt32(Console.ReadLine());

            //сравнение трех переменных
            int result = GetMinimum(first, second, third);
            Console.WriteLine($"The minimal value is {result}");

        }

    }
}
