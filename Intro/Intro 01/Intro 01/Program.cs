using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_01
{


    /* Задание 0.1
     * Написать функцию, формирующую и возвращающую строку вида 1, 2, 3, … N (положительное число).

        Значение N передаётся в функцию в качестве аргумента.

        Пример возвращаемого значения для N=7: 1, 2, 3, 4, 5, 6, 7
     * 
     * */
    class Program
    {
        static void Main(string[] args)
        {
            int N=0;
            AddValue(ref N);
            Console.Write(CreateString(N));
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

        //создание строки
        public static string CreateString(int N)
        {
            string str = "";
            for(int i = 1; i<N; i++)
            {
                str += i + ",";
            }
           return str += N;
        }

    }
}
