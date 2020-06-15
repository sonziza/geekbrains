using System;
using System.IO;

namespace Homework4
{
    struct Account
    {
        readonly string login;
        readonly string password;
        readonly string[] account;

        public Account(string path, string ulogin, string upassword)
        {
            //Получаем логин и пароль из файла
            account = new string[2];
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(path);
                account[0] = sr.ReadLine();
                account[1] = sr.ReadLine();
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
                if (sr != null)
                {
                    sr.Close();

                }
            }
            //Получаем логин и пароль от пользователя
            login = ulogin;
            password = upassword;
        }
        /// <summary>
        /// Проверка логина и пароля
        /// </summary>
        /// <returns>true = вход выполнен</returns>
        public bool Check()
        {
            string ulog = account[0];
            if (login == ulog && password == account[1])
            {
                return true;
            }
            else return false;
        }
    }

    public partial class Program
    {
        static void Task3()
        {
            //файл авторизации
            string authFile = "Authentication.txt";

            Console.WriteLine("Введите логин");
            string userLogin = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            string userPassword = Console.ReadLine();
            Account Acc1 = new Account(authFile, userLogin, userPassword);
            if (Acc1.Check() == true)
            {
                Console.WriteLine("Вход выполнен!");
            }
            else
            {
                Console.WriteLine("Ошибка доступа.");
            }
            Console.ReadLine();

        }
    }
}
