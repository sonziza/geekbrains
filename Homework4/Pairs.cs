using System;

namespace Homework4
{
    /// <summary>
    /// 1. Дан целочисленный массив из 20 элементов. Элементы массива могут 
    /// принимать целые значения от –10 000 до 10 000 включительно. Написать 
    /// программу, позволяющую найти и вывести количество пар элементов массива, 
    /// в которых хотя бы одно число делится на 3. В данной задаче под парой 
    /// подразумевается два подряд идущих элемента массива. Например, для массива 
    /// из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
    /// </summary>
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
                Console.WriteLine(array[i]);
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
            Console.ReadLine();
            Console.WriteLine($"\n\n {GetPairs(myArray)}");
            Console.ReadLine();

        }
    }
    class Pairs
    {

    }
}
