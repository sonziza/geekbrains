using System;
using System.IO;

namespace Homework4
{
    class Matrix
    {
        int[,] matr;
        //С В О Й С Т В А
        #region
        //максимальное значение массива
        public int Max
        {
            get
            {
                int max = matr[0,0];
                foreach (int item in matr)
                {
                    if (item > max)
                    {
                        max = item;
                    }
                }
                return max;
            }
        }
        //минимальное значение массива
        public int Min
        {
            get
            {
                int min = matr[0, 0];
                for (int i = 0; i < matr.GetLength(0); i++)
                {
                    for (int j = 0; j < matr.GetLength(1); j++)
                    {
                        if (matr[i, j] < min) min = matr[i, j];
                    }
                }
                return min;
            }
        }
        #endregion

        //К О Н С Т Р У К Т О Р Ы
        #region
        /// <summary>
        /// Создание двумерного массива с заданной размерностью
        /// </summary>
        /// <param name="row">количество строк</param>
        /// <param name="col">и столбцов</param>
        public Matrix(int row, int col)
        {
            matr = new int[row, col];
            Random rnd = new Random();
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    matr[i, j] = rnd.Next(-100, 100);
                }
            }
        }
        /// <summary>
        /// Создание массива из файла
        /// </summary>
        /// <param name="path">путь к файлу</param>
        public Matrix(string path)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(path);
                int row = Convert.ToInt32(sr.ReadLine());
                int col = Convert.ToInt32(sr.ReadLine());
                matr = new int[row, col];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        matr[i, j] = Convert.ToInt32(sr.ReadLine());
                    }
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
        #endregion

        //М Е Т О Д Ы
        #region
        /// <summary>
        /// Информация о массиве как экземпляре класса
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    s = s + matr[i, j] + " ";
                }
                s += "\n";
            }
            return s;
        }
        /// <summary>
        /// Получить сумму элементов массива
        /// </summary>
        /// <returns></returns>
        public int GetSum()
        {
            int sum = 0;
            for(int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    sum += matr[i, j];
                }
            }
            return sum;
        }
        /// <summary>
        /// Получить сумму элементов массива со значением больше заданного
        /// </summary>
        /// <param name="val">минимальное значение</param>
        /// <returns>сумма элементов массива</returns>
        public int GetSumOver(int val)
        {
            int sum = 0;
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (matr[i, j] > val)
                    {
                        sum += matr[i, j];
                    }
                }
            }
            return sum;
        }
        /// <summary>
        /// Получить индекс максимального значения
        /// TODO: номер и индекс - одно и тоже?
        /// </summary>
        /// <returns></returns>
        public string GetMaxIndex()
        {
            int max = matr[0, 0];
            int col = 0;
            int row = 0;
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (matr[i, j] > max)
                    {
                        max = matr[i, j];
                        row = i;
                        col = j;
                    }
                }
            }
            string index = $"[{row},{col}]";
            return index;
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
                sw.WriteLine(matr.GetLength(0));
                sw.WriteLine(matr.GetLength(1));
                foreach (int item in matr)
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
        #endregion

    }
    public partial class Program
    {
        static void Task4()
        {

            Matrix matrixB = new Matrix("file.txt");
            Console.WriteLine(matrixB);



            Console.WriteLine("Введите размерность массива (строки, столбцы)");
            int rows = Convert.ToInt32(Console.ReadLine());
            int columns = Convert.ToInt32(Console.ReadLine());
            Matrix matrixA = new Matrix(rows, columns);
            Console.WriteLine(matrixA);
            Console.WriteLine("Maximal element: " + matrixA.Max);
            Console.WriteLine("Minimal element: " + matrixA.Min);
            Console.WriteLine("Сумма элементов массива: " + matrixA.GetSum());
            Console.WriteLine("Сумма элементов массива со значением больше 0: " + matrixA.GetSumOver(0));
            Console.WriteLine("Индекс максимального значения: " +matrixA.GetMaxIndex());

            string pathToFile= "file.txt";
            matrixA.WriteToFile(pathToFile);




            Console.ReadLine();

        }

    }
}
