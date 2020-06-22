using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    //1. Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double, double).
    // Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).

    //Описываем делегат
    public delegate double Fun(double x);//double(double)
    public delegate double Fun2(double x, double y);//double(double,double)


    public partial class Program
    {
        public static void Table(Fun F, double start, double finish, double h)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (start <= finish)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", start, F(start) /*F(a)*/);
                start += h;
            }
            Console.WriteLine("---------------------");
            Console.ReadLine();
        }

        public static double MyFunc(double x)//double(double)
        {
            return x * x * x;
        }

        public static double MyFunc2(double x)
        {
            return Math.Cos(Math.Log(x));
        }
        public static void Table2(Fun2 F2, double start, double finish, double h)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (start <= finish)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", start, F2(start, h) /*F(a)*/);
                start += h;
            }
            Console.WriteLine("---------------------");
            Console.ReadLine();
        }

        //функция a*x^2
        public static double MyFunc3(double x, double y)
        {
            return x * (y * y);
        }

        //функция a*sin(x)
        public static double MyFunc4(double x, double y)
        {
            return x * Math.Sin(y);
        }


        static void Task1()
        {
            Console.WriteLine("значение a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("значение b:");
            int b = int.Parse(Console.ReadLine());
            Fun fun = new Fun(Math.Atan);
            Table(fun, a, b, 1);
            Table(new Fun(Math.Atan), -4, 4, 1);
            //Table(null, -4, 4, 1);
            //Создаем новый делегат и передаем ссылку на него в метод Table. 
            Console.WriteLine("Таблица функции MyFunc:");
            Table(new Fun(MyFunc), -2, 2, 1);//Параметры функции и тип возвращаемого значения, должны совпадать с делегатом
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            Table(MyFunc, -2, 2, 1);//Упрощение(c C# 2.0). Делегат создается автоматически. 

            //Создаем ссылку на a*x^2 для делегата Fun2
            Console.WriteLine("Таблица функции a*x^2:");
            Table2(new Fun2(MyFunc3), -2, 2, 1);
            //Создаем ссылку на a*sin(x) для делегата Fun2
            Console.WriteLine("Таблица функции a*sin(x):");
            Table2(new Fun2(MyFunc3), -2, 2, 1);


            Console.ReadKey();
        }
    }
}