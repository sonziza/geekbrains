using System;
using System.IO;

namespace Homework4
{
    class MyArray
    {
        int[] a;
        //С В О Й С Т В А
        // возвращает сумму элементов массива
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i=0; i<a.Length; i++)
                {
                    sum += a[i];
                }
                return sum;
            }
        }
        //максимальное значение массива
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        //минимальное значение массива
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        //количество положительных чисел
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        //количество максимальных значений в массиве
        public int MaxCount
        {
            get
            {
                int maxcount = 0;
                
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i] > max) max = a[i];
                }
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == max) maxcount++;
                }
                return maxcount;
            }
        }
        //К О Н С Т Р У К Т О Р Ы
        /// <summary>
        /// TODO: Как сделать перегрузку для двух идентичных методов? 
        /// В качестве костыля - double
        /// 
        /// Массив заданной размерности и заполняющий массив числами от
        /// начального значения с заданным шагом
        /// </summary>
        /// <param name="n">размерность</param>
        /// <param name="fv">начальное значение</param>
        /// <param name="s">шаг</param>
        public MyArray(int n, double fv, int s)
        {
            a = new int[n];
            for (int i = 0; i < n; i++, fv+=s)
                a[i] = Convert.ToInt32(fv);
        }
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }

        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max + 1);
        }
        /// <summary>
        /// Создание массива из файла
        /// </summary>
        /// <param name="path">путь к файлу</param>
        public MyArray(string path)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(path);
                int n = Convert.ToInt32(sr.ReadLine());
                a = new int[n];
                for (int i = 0; i<n; i++)
                {
                    a[i] = Convert.ToInt32(sr.ReadLine());                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();

                }
            }
        }


        // М Е Т О Д Ы
        /// <summary>
        /// Информация об экземпляре классе, выводится на консоль
        /// </summary>
        /// <returns>массив</returns>
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
        /// <summary>
        /// Меняет знак каждого элемента в массиве
        /// </summary>
        public void Inverse()
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] * (-1);
            }
        }
        /// <summary>
        /// Умножает каждый элемент массива на определенное число
        /// </summary>
        /// <param name="mul"></param>
        public void Multi(int mul)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] * mul;
            }
        }
        /// <summary>
        /// Запись массива в файл
        /// </summary>
        /// <param name="path">путь к файлу</param>
        public void WriteToFile(string path)
        {
            StreamWriter sw = new StreamWriter(path);
            try
            {
                sw.WriteLine(a.Length);
                foreach (int item in a)
                {
                    sw.WriteLine(item);
                }
                Console.WriteLine("Запись в " + path + " завершена!");
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }
    }

    public partial class Program
    {
        static void Task2()
        {
            string pathToFile = "Homework.txt";
            MyArray a = new MyArray(6, -10, 10);
            // Вызов метода ToString
            Console.WriteLine($"Array a's info: {a}");
            Console.WriteLine($"The max: {a.Max}");
            Console.WriteLine($"The min: {a.Min}");
            Console.WriteLine($"The sum: {a.Sum}");
            Console.WriteLine($"The maxcount: {a.MaxCount}");
            Console.WriteLine($"The count of positiv elements: {a.CountPositiv}");
            a.Inverse();
            Console.WriteLine($"Inverted array{a}");
            MyArray b = new MyArray(8, 5.0, 5);
            Console.WriteLine($"Array b's info: {b}");
            b.WriteToFile(pathToFile);
            MyArray c = new MyArray("123.txt");
            Console.WriteLine($"Array c's info: {c}");

            Console.ReadKey();
        }
    }
}
