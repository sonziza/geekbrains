using System;
/// <summary>
/// С клавиатуры вводятся числа, пока не будет введен 0. 
/// Подсчитать сумму всех нечетных положительных чисел.
/// </summary>

namespace Homework2
{
    public partial class Homework2
    {
        public static void Task3()
        {
            int oddsum = 0;
            int value;

            Console.WriteLine("Please enter some number! The number 0 will terminate the task");
            do
            {
                value = Convert.ToInt32(Console.ReadLine());
                if (value > 0 && value % 2 != 0)
                {
                    oddsum += value;
                }
            }
            while (value != 0);
            Console.WriteLine($"The sum of odd numbers is {oddsum}");
        }
    }
}
