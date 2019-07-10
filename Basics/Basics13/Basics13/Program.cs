using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics13
{

    /*---Задача 1.3---
     * Написать программу, которая запрашивает с клавиатуры число N и выводит на экран следующее «изображение», состоящее из N строк:
     * */
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            AddValue(ref N);
            ShowTriangle(N);
            Console.ReadKey();
        }

        //добавление значения
        public static void AddValue(ref int value)
        {
            Console.WriteLine("Введите положительное число: ");
            string temp = Console.ReadLine();
            if (CheckValue(temp) == true) value = int.Parse(temp);
            else
            {
                Console.WriteLine("Вы ввели неверное зничение. Повторите ввод.");
                AddValue(ref value);
            }
        }

        //проверка значения
        public static bool CheckValue(string value)
        {
            try
            {
                return int.Parse(value) > 0 ;
            }
            catch
            {
                return false;
            }
        }

        //вывод треугольника
        public static void  ShowTriangle(int N)
        {
            for(int i=1;i<=N;i++)
            {
                for(int k=i;k<N;k++)
                {
                    Console.Write(" ");
                }
                for(int j=0;j<i*2-1;j++)
                {
                    Console.Write("*");
                }
                Console.Write(Environment.NewLine);
            }
        }

    }
}
