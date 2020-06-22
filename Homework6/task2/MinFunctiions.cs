using System;
using System.IO;

namespace Homework6{
    public delegate double Function(Double x);


    public partial class Program
    {

        public static double F1(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double F2(double x)
        {
            return x * x - 10 * x + 50;
        }

        public static void SaveFunc(string fileName, double a, double b, double h, Function func)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            //            StreamWriter sw = new StreamWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(func(x));
                //                sw.WriteLine(F(x));
                x += h;//x=x+h;
            }
            Console.ReadLine();
            bw.Close();
            fs.Close();
        }

        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                //Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        
        public static void Task2()
        {
            Function[] funcs = {F1, F2, Math.Sin, Math.Cos};

            Console.WriteLine("Сделайте выбор: 1 - функция F1, 2 - функция F2");
            int index = Convert.ToInt32(Console.ReadLine());            
            SaveFunc("data.bin", -100, 100, 0.5, funcs[index - 1]);

            Console.WriteLine(Load("data.bin"));
            Console.ReadLine();
        }


    }
}
