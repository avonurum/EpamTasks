using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop21
{
    /*---Задание 2.1---
     Написать класс Round, задающий круг с указанными координатами центра, радиусом, а также свойствами, 
     позволяющими узнать длину описанной окружности и площадь круга. 
     Обеспечить нахождение объекта в заведомо корректном состоянии. Написать программу, демонстрирующую использование данного круга.
         */

    enum RoundParams
    {
        Координата_X,
        Координата_Y,
        Радиус
    }
        
    class Program
    {
        static bool status = true;
        static void Main(string[] args)
        {
            Round r=new Round(0,0,10);
            while(status==true)
            {
                Menu(ref r);
            }
        }

        static void Menu( ref Round r)
        {
            
                Console.WriteLine("Выберите: ");
                Console.WriteLine(" 1.Вывести радиус \n 2.Изменить радиус \n 3.Вывести площадь \n " +
                    "4.Вывести длину описанной окружности \n 5.Изменить координату X \n 6.Изменить координату Y " +
                    "\n 7.Вывести координаты \n 8.Выход" );
                switch(Console.ReadLine())
                {
                    case "1":Console.WriteLine(r.Radius); break;
                    case "2":r.Radius = AddValue(RoundParams.Радиус);break;
                    case "3": Console.WriteLine(r.Area); break;
                    case "4": Console.WriteLine(r.Circumference); break;
                    case "5": r.X= AddValue(RoundParams.Координата_X); break;
                    case "6": r.Y = AddValue(RoundParams.Координата_Y); break;
                    case "7": Console.WriteLine(RoundParams.Координата_X + " " + r.X +Environment.NewLine + RoundParams.Координата_Y + " "+ r.Y); break;
                    case "8": status=false; break;
                    default:Console.WriteLine("Вы ввели неверное значение");break;
                }
        }

        static double AddValue(RoundParams r) //добавление значения
        {
            Console.WriteLine(r+":");
            string value=Console.ReadLine();
            try
            {
               return int.Parse(value);
            }
            catch
            {
                Console.WriteLine("Введенные данные не являются числом. Повторите ввод");
                return AddValue(r);
            }
        }

    }   
}
