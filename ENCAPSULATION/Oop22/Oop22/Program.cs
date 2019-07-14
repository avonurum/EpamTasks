using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop22
{
    /* ---Задание 2.2---
     * Написать класс Triangle, описывающий треугольник со сторонами a, b, c 
     * и позволяющий осуществить расчёт его площади и периметра. Написать программу, демонстрирующую использование данного треугольника.
     * */
    class Program
    {
        enum TriangleParam
        {
            Сторона_а,
            Сторона_b,
            Сторона_c,
            Периметр,
            Площадь
        }
        static bool status=true;
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3,3,3);
            while (status == true)
            {
                Menu(ref triangle);
            }
        }

        static void Menu(ref Triangle triangle)
        {
            Console.WriteLine("Выберите: ");
            Console.WriteLine(" 1.Вывести стороны треугольника \n 2.Изменить сторону a \n 3.Изменить сторону b \n " +
                "4.Изменить сторону c \n 5.Вывести площадь треугольника \n 6.Вывести периметр треугольника \n" +
                " 7.Выход");
            switch (Console.ReadLine())
            {
                case "1": Console.WriteLine($"{TriangleParam.Сторона_а.ToString()}:{triangle.A}\n" +
                    $"{TriangleParam.Сторона_b.ToString()}:{triangle.B}\n{TriangleParam.Сторона_c.ToString()}:{triangle.C}"); break;
                case "2": triangle.A = AddValue(TriangleParam.Сторона_а); break;
                case "3": triangle.B = AddValue(TriangleParam.Сторона_b); break;
                case "4": triangle.C = AddValue(TriangleParam.Сторона_c); break;
                case "5": Console.WriteLine(triangle.Area()); break;
                case "6": Console.WriteLine(triangle.Perimetr()); break;
                case "7": status = false; break;
                default: Console.WriteLine("Вы ввели неверное значение"); break;
            }
        }

        static double AddValue(TriangleParam param)//добавление значения сторон треугольника
        {
            Console.Write(param + ":");
            string temp = Console.ReadLine();
            try
            {
                return double.Parse(temp);

            }
            catch
            {
                Console.WriteLine("Вы ввели не число. Повторите ввод");
                return AddValue(param);
            }
        }
    }
}
