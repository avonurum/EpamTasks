using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String11
{
    class Program
        /* ---Задание 1.11---
         * Написать программу, которая определяет среднюю длину слова во введённой текстовой строке. Учесть, что символы пунктуации на длину слов влиять не должны. Регулярные выражения не использовать.
         * И не пытайтесь прописать все символы-разделители ручками. Используйте стандартные методы классов String и Char.
         * */
    {
        static void Main(string[] args)
        {
            string str = AddValue();
            char[] list = FindSep(str);//массив разделителей и знаков пунктуации
            string[] words = str.Split(list,StringSplitOptions.RemoveEmptyEntries);//разделение строки на слова
            int middle = MiddleLength(ref words,ref list);
            Console.WriteLine(middle);
            Console.ReadKey();
        }

        public static string AddValue()//добавление строки
        {
            Console.WriteLine("Введите строку:");
            return Console.ReadLine();
        }

        public static int MiddleLength(ref string[] words, ref char[]list)//нахождение средней длины слова
        {
            int sum = 0;
            foreach (string w in words)
            {
                sum += w.Length;
            }
            return sum / words.Length;
        }

        public static char[] FindSep(string str)//нахождение знаков пунктуации и разделителей.
        {
            char[] list = new char[20];
            int i = 0;
            foreach (char c in str)
            {

                if (char.IsPunctuation(c) == true || char.IsSeparator(c) == true)
                {
                    list[i] = c;
                    i++;
                }
            }
            return list;
        }
    }
}
