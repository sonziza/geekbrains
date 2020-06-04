using System;
/// <summary>
/// Написать метод подсчета количества цифр числа.
/// </summary>

namespace Homework2
{
    public partial class Homework2
    {
        public static void Task2()
        {
            Console.WriteLine("Enter your number:");
            int value = Convert.ToInt32(Console.ReadLine());

            string str = Convert.ToString(value);
            int symbols = 0;
            foreach (char ch in str)
            {
                symbols++;
            }
            Console.WriteLine($"the number of digits of the number is equal to {symbols}");
        }
    }
}
