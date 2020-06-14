using System;

namespace Homework4
{
    public partial class Program
    {
        /// <summary>
        /// Создать массив из 20ти случайных чисел от -20000 до 20000
        /// </summary>
        /// <returns></returns>
        public static int[] CreateArray()
        {
            int[] array = new int[20];
            Random rnd = new Random();

            for (int i = 0; i<20; i++)
            {
                array[i] = rnd.Next(-6, 6);
            }
            return array;
        }
        /// <summary>
        /// Вывести массив на консоль
        /// </summary>
        /// <param name="array">имя массива</param>
        public static void GetArray(int[] array)
        {
            for(int i=0; i< array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        /// <summary>
        /// Получить количество пар элементов массива, в котором хотя бы один элемент кратен трём
        /// </summary>
        /// <param name="array">имя массива</param>
        /// <returns>количество пар</returns>
        public static int GetPairs(int[] array)
        {
            int pairs = 0;
            int i = 1;
            while (i < 20)
            {
                if (array[i-1]%3 ==0 || array[i] % 3 == 0)
                {
                    pairs++;
                }
                i++;
            }
            return pairs;
        }        


        public static void Task1()
        {
            int[] myArray = CreateArray();
            GetArray(myArray);
            Console.WriteLine($"\nКоличество пар элементов, делящихся на 3: {GetPairs(myArray)}");
            Console.ReadLine();
        }
    }
    class Pairs
    {

    }
}
