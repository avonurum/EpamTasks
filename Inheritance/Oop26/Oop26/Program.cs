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
            Внешний_радиус=0,
            Внутренний_радиус=1,
            Площадь=2,
            Сумма_длин=3
        }
        public static bool status = true;
        static void Main(string[] args)
        {
            Ring r = new Ring(1, 2);
            while(status)
            {
                Menu(ref r);
            }
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
                    case "1": Console.WriteLine(ring.Outer.Radius); break;
                    case "2": double temp = AddValue(RingParams.Внешний_радиус);
                                if (ring.CheckRadius(ring.Inner.Radius, temp)) ring.Outer.Radius = temp;
                                else Console.WriteLine("Операция не была произведена"); break;
                    case "3": Console.WriteLine(ring.Inner.Radius); break;
                    case "4":temp = AddValue(RingParams.Внутренний_радиус);
                            if (ring.CheckRadius(temp, ring.Outer.Radius)) ring.Inner.Radius = temp;
                            else Console.WriteLine("Операция не была произведена"); break;
                    case "5": Console.WriteLine(ring.Area); break;
                    case "6": Console.WriteLine(ring.Outer.Length);break;
                    case "7": status = false; break;
                    default: Console.WriteLine("Вы ввели неверное значение"); break;
                }
        }

        static double AddValue(RingParams p)
        {
            Console.WriteLine(p + ":");
            string value = Console.ReadLine();
            try
            {
                return double.Parse(value);
            }
            catch
            {
                Console.WriteLine("Введенные данные не верны. Повторите ввод");
                return AddValue(p);
            }
        }
    }
}
