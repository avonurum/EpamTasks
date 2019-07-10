using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics12
{

    /*  ---Задание 1.2---
     *  Написать программу, которая запрашивает с клавиатуры число N и выводит на экран следующее «изображение», состоящее из N строк:
     *  */
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            AddValue(ref N);
            CreateTriangle(N);
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
                return int.Parse(value) > 0;
            }
            catch
            {
                return false;
            }
        }

        //создание треугольника
        public static void CreateTriangle(int N)
        {
            for(int i=1;i<=N;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Show("*");
                }
                Show(Environment.NewLine);
            }
        }
        //вывод треугольника
        public static void Show(string s)
        {
            Console.Write(s);
        }
    }
}
