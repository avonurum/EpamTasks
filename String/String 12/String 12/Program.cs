using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_12
{
    /*---Задание 1.12---
     * Написать программу, которая удваивает в первой введённой строке все символы, принадлежащие второй введённой строке.
     * */
    class Program
    {
        static void Main(string[] args)
        {
            string fString = AddValue();//строка 1
            string sSrting = AddValue();//строка 2
            string result = toDoubleChar(ref fString,ref sSrting);
            
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static string AddValue()//добавление значения
        {
            Console.WriteLine("Введите строку:");
            return Console.ReadLine();
        }
        public static string toDoubleChar(ref string fstr,ref string sstr)//удвоение символов
        {
            for (int i = 0; i < sstr.Length; i++)
            { 
                string st = sstr[i].ToString() + sstr[i].ToString();
                string e = sstr[i].ToString();
                fstr = fstr.Replace(e, st);
                sstr = sstr.Replace(sstr[i],' ');//заменяем все повторяющиеся символы на пробелы
            }
            return fstr;
        }

    }
}
