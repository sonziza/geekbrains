using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public partial class Program
    {
		/// <summary>
		/// Сравнение строк с помощью метода OrderBy
		/// </summary>
		/// <param name="strFirst">первая строка</param>
		/// <param name="strSecond">вторая строка</param>
		/// <returns>true - строки переставляются</returns>
		static bool IsSameString(string strFirst, string strSecond)
		{
			// если размеры строк отличаются то сразу выводим false
			if (strFirst.Length != strSecond.Length)
			{
				return false;
			}

			// преобразуем строки в символьные массивы для сортировки
			char[] firstArr = strFirst.OrderBy(x => x).ToArray();
			char[] secondArr = strSecond.OrderBy(x => x).ToArray();

			// сравниваем две отсортированные "строки"
			for (int i = 0; i < firstArr.Length; ++i)
			{
				if (firstArr[i] != secondArr[i])
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>
		/// Сравнение строк, используя танцы с бубном
		/// TODO: Нужна оптимизация
		/// </summary>
		/// <param name="strFirst">первая строка</param>
		/// <param name="strSecond">вторая строка</param>
		/// <returns>true - строки переставляются</returns>
		static bool IsSameStringMy(string strFirst, string strSecond)
		{
			// если размеры строк отличаются то сразу выводим false
			if (strFirst.Length != strSecond.Length)
			{
				return false;
			}

			//счетчик количества совпадающих символов
			int count = 0;

			for(int i = 0; i<strFirst.Length; i++)
			{
				count = 0;
				for (int j = 0; j < strSecond.Length; j++)
				{
					if(strFirst[i] == strSecond[j])
					{
						count++;
					}
				}
				//если i-й символ ни разу встретился по прохождении strSecond - дальнейшее сравнение не требуется
				if (count == 0)
				{
					return false;
				}
			}

			return true;
		}



		static void Task3()
        {
            Console.WriteLine("Введите первую строку");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку");
            string str2 = Console.ReadLine();
			str1.ToLower();
			str2.ToLower();

			DateTime dt1, dt2;

			dt1 = DateTime.Now;
			//сравнение с помощью методов
			Console.WriteLine(IsSameString(str1, str2));
			Console.WriteLine("Время выполнения сравнения с методами: " + Convert.ToString(dt1 - DateTime.Now));

			dt2 = DateTime.Now;			
			//сравнение с помощью танцев с бубнами
			Console.WriteLine(IsSameStringMy(str1, str2));
			Console.WriteLine("Время выполнения моего алгоритма 2: " + Convert.ToString(dt2 - DateTime.Now));




			Console.WriteLine();
			Console.ReadLine();

        }
    }
}
