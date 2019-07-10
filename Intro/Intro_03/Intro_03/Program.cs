using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_03
{
    /* ---Задание 0.3---
     * Написать функцию, выводящую на экран квадрат из звёздочек со стороной равной N (положительное нечётное целое число). Центральная звёздочка должна отсутствовать.

       Значение N передаётся в функцию в качестве аргумента.

       На изображении приведён пример работы функции для N=7.
       */
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            AddValue(ref N);
            CreateSquare(N);
            Console.ReadKey();
        }

        //добавление значения
        public static void AddValue(ref int value)
        {
            Console.WriteLine("Введите положительное нечетное число: ");
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
                return int.Parse(value) > 0 && int.Parse(value)%2!=0 ;
            }
            catch
            {
                return false;
            }
        }
        //создание квадрата звездочек
        public static void CreateSquare(int value)
        {
            char[,] stars = new char[value, value];
            for(int i=0;i<value;i++)
            {
                for(int j=0;j<value;j++)
                {
                    stars[i, j] = '*';
                }
            }
            int middle =(value / 2);
            stars[middle, middle] = ' ';//середину квадрата опустошаем
            Show(stars, value);
        }

        //вывод квадрата
        public static void Show(char[,] array, int value)
        {
            for (int i = 0; i < value; i++)
            {
                for (int j = 0; j < value; j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}
