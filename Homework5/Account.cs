using System;
using System.Text.RegularExpressions;

namespace Homework5
{
    class Account
    {
        string login;
        string password;
        //корректный логин - строка от 2 до 10 символов (только буквы латинского алфавита или цифры, при этом цифра не может быть первой)
        readonly static Regex loginReg = new Regex(@"^[a-zA-Z][a-zA-Z0-9]{2,10}$");
        public Account(string ulogin, string upassword)
        {
            login = ulogin;
            password = upassword;
        }
        public static bool CheckLogin(string ulogin)
        {
            bool isCorrect = loginReg.IsMatch(ulogin);
            return isCorrect;
        }
        public override string ToString()
        {
            return $"Логин: {login} \nПароль: {password}";
        }
        public static string HidePassword()
        {
            string inpt = string.Empty;
            while (true)
            {
                var key = Console.ReadKey(true);//не отображаем клавишу - true

                if (key.Key == ConsoleKey.Enter) break; //enter - выходим из цикла

                Console.Write("*");//рисуем звезду вместо нее
                inpt += key.KeyChar; //копим в пароль символы
            }
            Console.WriteLine();
            return inpt;
        }
    }

    public partial class Program
    {
        static void Task1()
        {
            Console.WriteLine("Придумайте логин. Внимание, логин должен содержать цифры и латинские, а также начинаться только с буквы");
            string userLogin = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            string userPassword = Account.HidePassword();
            if (Account.CheckLogin(userLogin) == true)
            {
                Console.WriteLine("Вход выполнен успешно!");
                Account acc1 = new Account(userLogin, userPassword);
                Console.WriteLine(acc1);
            }
            else
            {
                Console.WriteLine("Проверьте корректность Вашего логина!");
            }
            Console.ReadLine();
        }
    }
}
