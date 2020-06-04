using System;
/// <summary>
/// Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
/// На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
/// Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
/// программа пропускает его дальше или не пропускает. 
/// С помощью цикла do while ограничить ввод пароля тремя попытками.
/// </summary>

namespace Homework2
{
    public partial class Homework2
    {
        static bool Autorisation(string user, string pass)
        {
            if (user.ToLower() == "root" && pass == "GeekBrains")
            {
                return true;
            }
            else
            {
                Console.WriteLine("The login or password is not correct.");
                return false;
            } 
        }
        public static void Task4()
        {
            bool check;
            int count = 0;
            do
            {
                Console.WriteLine("Please enter your login");
                string login = Console.ReadLine();
                Console.WriteLine("Please enter your password");
                string password = Console.ReadLine();
                count++;
                check = Autorisation(login, password);
            }
            while (check == false && count < 3);
            if (check == true)
            {
                Console.WriteLine("Welcome!");
            }
            else Console.WriteLine("Exceeded the number of attempts!");

        }
    }
}
