using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace Homework5
{
    class Message
    {
        /// <summary>
        /// Вывод на консоль
        /// </summary>
        /// <param name="words"></param>
        public static void GetWords(string[] words)
        {
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
        /// <summary>
        ///Вывести только те слова сообщения, которые содержат не более n букв
        /// </summary>
        /// <param name="words">массив слов</param>
        /// <param name="nLetter">количество букв, значение которого нельзя превышать</param>
        public static void GetWords(string[] words, int nLetter)
        {
            Console.WriteLine($"Список слов, содержащих менее {nLetter} букв");
            foreach (string word in words)
            {
                if (word.Length < nLetter)
                {
                    Console.WriteLine(word);
                }
            }
            Console.ReadLine();
            ExportToFile(words);
        }
        /// <summary>
        /// Удалить слова, начинающиеся на определенную букву
        /// </summary>
        /// <param name="text">сообщение</param>
        /// <param name="letter">первая буква в слове</param>
        /// <returns>Сообщение с удаленными словами</returns>
        public static string DeleteWords(string text, char letter)
        {
            Regex regWords = new Regex(@"\b[" + Convert.ToString(letter) + @"]\w+");
            string formattedText = regWords.Replace(text, "");
            Console.WriteLine(formattedText);
            Console.ReadLine();

            string[] formattedWords = formattedText.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            ExportToFile(formattedWords);

            return formattedText;
        }
        /// <summary>
        /// Вывести самое длинное слово сообщения
        /// </summary>
        /// <param name="words">массив слов</param>
        public static void TheLargestWrod(string[] words)
        {
            string largestWord;
            int index = 0;
            for (int i = 1; i < words.Count(); i++)
            {
                if (words[i].Length > words[i - 1].Length)
                {
                    index = i;
                }
            }
            largestWord = words[index];
            string msgInfo = "Cамое длинное слово сообщения";
            Console.WriteLine(msgInfo);
            Console.WriteLine(largestWord);
            Console.ReadLine();
        }

        public static void ExportToFile(string[] fWords)
        {
            string path = "message.txt";
            StreamWriter sw = new StreamWriter(path);
            try
            {
                foreach (string item in fWords)
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
            //Ввод сообщения и преобразование в массив слов
            Console.WriteLine("Наберите какое-нибудь предложение: ");
            string someText = Console.ReadLine();
            string[] words = someText.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            //Вывести список слов
            Message.GetWords(words);
            Console.WriteLine();

            //Вывести только те слова сообщения, которые содержат не более n букв
            Message.GetWords(words, 5);

            //Вывести все слова кроме тех, которые начинаются с указанной буквы
            Console.WriteLine("Укажите букву");
            char letterForDelete = Convert.ToChar(Console.ReadLine());
            Message.DeleteWords(someText, letterForDelete);

            //Вывести самое длинное слово сообщения
            Message.TheLargestWrod(words);

            //Сформировать строку с помощью StringBuilder из самых длинных слов сообщения. Ввести кол-во слов
            //int count = Convert.ToInt32(Console.ReadLine());


        }
    }
}
