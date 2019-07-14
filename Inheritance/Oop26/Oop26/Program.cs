using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop26
{
    class Program
    {
        enum RingParams
        {
            Внешний_радиус,
            Внутренний_радиус,
            Площадь,
            Сумма_длин
        }
        public static bool status = true;
        static void Main(string[] args)
        {
            Ring r = new Ring(1, 2);
            Console.WriteLine(r.Area);
            Console.ReadKey();
        }

        static void Menu(ref Ring ring)
        {
                Console.WriteLine("Выберите: ");
                Console.WriteLine(" 1.Вывести внешний радиус кольца \n 2.Изменить внешний радиус кольца \n 3.Вывести внутренний радиус кольца \n " +
                    "4.Изменить внутренний радиус кольца \n 5.Вывести площадь кольца \n 6.Вывести сумму длин окружностей " +
                    "\n 7.Выход \n");
                switch (Console.ReadLine())
                {
                    case "1":  break;
                    case "2": break;
                    case "3": break;
                    case "4":  break;
                    case "5": break;
                    case "6": break;
                    case "7": status = false; break;
                    default: Console.WriteLine("Вы ввели неверное значение"); break;
                }
        }

        static double AddValue()
        {
            
            string value = Console.ReadLine();
            try
            {
                return double.Parse(value);
            }
            catch
            {
                Console.WriteLine("Введенные данные не верны. Повторите ввод");
                return AddValue();
            }
        }
    }
}
