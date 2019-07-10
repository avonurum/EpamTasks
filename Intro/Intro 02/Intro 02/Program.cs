using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_02
{

    /*  ---Задание 0.2---
     Число считается простым, если его можно разделить без остатка только на единицу и на само себя (например, 7).

     Необходимо написать функцию, определяющую, является ли заданное число N (положительное целое) простым.

     Значение N передаётся в функцию в качестве аргумента.
         
         */
    class Program
    {
        static void Main(string[] args)
        {
            int N =0;
            AddValue(ref N);
            Console.WriteLine(IsPrimeNumber(N));
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
        //проверка, является ли число простым
        public static bool IsPrimeNumber(int value)
        {
            if(value == 1)
            {
                return true;     
            }
            else
            {
                for(int i=2;i< value;i++)
                {
                    if(value%i==0) //если  остаток от деления на i-ый элемент равен нулю, то число не является простым.
                    {
                        return false;
                    }
                }
                return true;
            }
              
        }
    }
}
